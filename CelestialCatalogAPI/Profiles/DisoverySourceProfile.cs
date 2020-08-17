using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CelestialCatalogAPI.Profiles
{
    public class DisoverySourceProfile:Profile
    {
        public DisoverySourceProfile()
        {
            CreateMap<Entities.DiscoverySource, Models.DiscoverySourceDto>();
            CreateMap<Models.DiscoverySourceDto, Entities.DiscoverySource>();
               
        }
    }
}
