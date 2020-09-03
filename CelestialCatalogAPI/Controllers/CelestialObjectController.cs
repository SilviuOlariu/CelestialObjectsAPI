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
        private readonly TypeCalculator _typeCalculator;
        public CelestialObjectController(IMapper mapper, ICatalogRepository catalogRepository, TypeCalculator typeCalculator)
        {
            _mapper = mapper;
            _catalogRepository = catalogRepository;
            _typeCalculator = typeCalculator;
        }
        [HttpGet]
        [Route(CelestialRoutes.Objects)]
        public IActionResult GetCelestialObjects()
        {
            var celestialObject = _catalogRepository.GetCelestialObjects();
            return Ok(celestialObject);
        }
        [HttpGet]
        [Route(CelestialRoutes.ObjectsByType)]
        public IActionResult GetCelestialObjectsByType(string type)
        {
            var celestialObject = _catalogRepository.GetCelestialObjectbyType(type);     
            return Ok(celestialObject);

        }
        [HttpGet]
        [Route(CelestialRoutes.ObjectsByName)]
        public IActionResult GetCelestialObjectByName(string name)
        {
            var celestialObject = _catalogRepository.GetCelestialObjectsByName(name);
            return Ok(celestialObject);
        }
        [HttpGet]
        [Route(CelestialRoutes.ObjectByCountry)]
        public IActionResult GetCelestialObjectByCountry(string country)
        {
            var celestialObject = _catalogRepository.GetObjectByCountry(country);
            return Ok(celestialObject);
        }
        [HttpPost]
        [Route(CelestialRoutes.Objects)]
        public IActionResult CreateCelestialObject([FromBody] CelestialObjectDto celestialObjectDto)
        {
            if(!ModelState.IsValid)
            {
                return NotFound();
            }
          
            var celestialObject = _mapper.Map<CelestialObject>(celestialObjectDto);
            _typeCalculator.SetCelestialObjectType(celestialObject);
            _catalogRepository.AddCelestialObject(celestialObject);
            _catalogRepository.Save();
               return Ok(celestialObject);
        }
       
    }
}
