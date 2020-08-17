using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CelestialCatalogAPI.Models
{
    public class DiscoverySourceDto
    {
        public string Name { get; set; }
        public DateTime EstablishmentDate { get; set; }
        public string Type { get; set; }
        public string StateOwner { get; set; }
    }
}
