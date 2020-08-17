using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CelestialCatalogAPI.Entities
{
    public class DiscoverySource
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime EstablishmentDate { get; set; }
        
        public string StateOwner { get; set; }
        public string Type { get; set; }
       
   }



    
}