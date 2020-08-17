using CelestialCatalogAPI.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CelestialCatalogAPI.Contexts
{
    public class CelestialCatalogContext:DbContext
    {
        public CelestialCatalogContext(DbContextOptions<CelestialCatalogContext> options) : base(options)
        {

        }
        public DbSet<CelestialObject> CelestialObjects { get; set; }
        public DbSet<DiscoverySource> DiscoverySources { get; set; }

        
    }
}
