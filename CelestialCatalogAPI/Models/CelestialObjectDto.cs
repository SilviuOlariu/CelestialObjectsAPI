using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CelestialCatalogAPI.Models
{
    public class CelestialObjectDto
    {
        public string Name { get; set; }
        public double Mass { get; set; }
        public double EquatorialDiameter { get; set; }
        public int SurfaceTemperature { get; set; }
        public string Type { get; set; }
        public DateTime DiscoveryDate { get; set; }
        public int DiscoverySourceId { get; set; }

       
    }
}
