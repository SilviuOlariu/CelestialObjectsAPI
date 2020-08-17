using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CelestialCatalogAPI.Entities;
using CelestialCatalogAPI.Extensions;
using CelestialCatalogAPI.Models;
using CelestialCatalogAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CelestialCatalogAPI.Controllers
{
    [Route("api/[controller]")]
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
        public IActionResult GetCelestialObjects()
        {
            return Ok(_catalogRepository.GetCelestialObjects().ToList());
        }
        [HttpGet]
        [Route("{type}")]
        public IActionResult GetCelestialObjectsByType(string type)
        {
            return Ok(_catalogRepository.GetCelestialObjectbyType(type));
        }

        [HttpPost]
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
