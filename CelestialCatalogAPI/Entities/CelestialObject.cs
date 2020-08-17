using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CelestialCatalogAPI.Entities
{
    public class CelestialObject
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public double Mass { get; set; }
        [Required]
        public double EquatorialDiameter { get; set; }
        [Required]
        public int SurfaceTemperature { get; set; }
        [Required]
        public  string  Type { get; set; }
        public int DiscoverySourceId { get; set; }
        public DateTime DiscoveryDate { get; set; }
        [ForeignKey("DiscoverySourceId")]
        public DiscoverySource DiscoverySource { get; set; }
        




    }
}
