﻿using AutoMapper;
using CelestialCatalogAPI.Entities;
using CelestialCatalogAPI.Http;
using CelestialCatalogAPI.Models;
using CelestialCatalogAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CelestialCatalogAPI.Controllers
{
     [ApiController]
    public class DiscoverySourceController : ControllerBase
    {
        
        private readonly ICatalogRepository _catalogRepository;
        private readonly IMapper _mapper;
        public DiscoverySourceController(ICatalogRepository catalogRepository, IMapper mapper)
        {
            _catalogRepository = catalogRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [Route(DiscoveryRoutes.GetSources)]
        public IActionResult GetDiscoverySource()
        {
            return Ok(_catalogRepository.GetDiscoverySource());
            
        }
       
        [HttpPost]
        [Route(DiscoveryRoutes.PostSource)]
        public IActionResult AddDiscoverySource([FromBody] DiscoverySourceDto discoverySourceDto)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var disoverySource = _mapper.Map<DiscoverySource>(discoverySourceDto);
            _catalogRepository.AddDiscoverySource(disoverySource);
            _catalogRepository.Save();

            return Ok(disoverySource);
           
        }
    }
}
