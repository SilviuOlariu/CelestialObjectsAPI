using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CelestialCatalogAPI.Profiles
{
    public class CelestialObjectProfile:Profile
    {
        public CelestialObjectProfile()
        {
            CreateMap<Entities.CelestialObject, Models.CelestialObjectDto>();
            CreateMap<Models.CelestialObjectDto, Entities.CelestialObject>();
              
        }
    }
}
