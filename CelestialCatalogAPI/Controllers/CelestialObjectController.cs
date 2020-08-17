using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CelestialCatalogAPI.Entities;
using CelestialCatalogAPI.Extensions;
using CelestialCatalogAPI.Http.CelestialRoutes;
using CelestialCatalogAPI.Models;
using CelestialCatalogAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CelestialCatalogAPI.Controllers
{
    
    [ApiController]
    public class CelestialObjectController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ICatalogRepository _catalogRepository;
        public CelestialObjectController(IMapper mapper, ICatalogRepository catalogRepository)
        {
            _mapper = mapper;
            _catalogRepository = catalogRepository;
        }
        [HttpGet]
        [Route(CelestialRoutes.GetObjects)]
        public IActionResult GetCelestialObjects()
        {
            var celestialObject = _catalogRepository.GetCelestialObjects().ToList();
            var result = _mapper.Map<IEnumerable<CelestialObjectDto>>(celestialObject);
            return Ok(result);
        }
        [HttpGet]
        [Route(CelestialRoutes.GetObjectsByType)]
        public IActionResult GetCelestialObjectsByType(string type)
        {
            var celestialObject = _catalogRepository.GetCelestialObjectbyType(type);
            var result = _mapper.Map<IEnumerable<CelestialObjectDto>>(celestialObject);
            return Ok(result);
        }
        [HttpGet]
        [Route(CelestialRoutes.GetObjectsByName)]
        public IActionResult GetCelestialObjectByName(string name)
        {
            var celestialObject = _catalogRepository.GetCelestialObjectsByName(name);
            var result = _mapper.Map<IEnumerable<CelestialObjectDto>>(celestialObject);
            return Ok(result);
        }
        [HttpGet]
        [Route(CelestialRoutes.GetObjectByCountry)]
        public IActionResult GetCelestialObjectByCountry(string country)
        {
            var celestialObject = _catalogRepository.GetObjectByCountry(country);
            var result = _mapper.Map<IEnumerable<CelestialObjectDto>>(celestialObject);
            return Ok(result);
        }
        [HttpPost]
        [Route(CelestialRoutes.GetObjects)]
        public IActionResult CreateCelestialObject([FromBody] CelestialObjectDto celestialObjectDto)
        {
            if(!ModelState.IsValid)
            {
                return NotFound();
            }
          celestialObjectDto.ClassifyObject();
            var celestialObject = _mapper.Map<CelestialObject>(celestialObjectDto);
            _catalogRepository.AddCelestialObject(celestialObject);
            _catalogRepository.Save();
               return Ok(celestialObject);
        }
       
    }
}
