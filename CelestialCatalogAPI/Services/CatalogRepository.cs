using CelestialCatalogAPI.Contexts;
using CelestialCatalogAPI.Entities;
using CelestialCatalogAPI.Extensions;
using CelestialCatalogAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CelestialCatalogAPI.Services
{
    public class CatalogRepository : ICatalogRepository
    {
        public readonly CelestialCatalogContext _ctx;
        public CatalogRepository(CelestialCatalogContext ctx)
        {
            _ctx = ctx;
        }

        public void AddCelestialObject(CelestialObject celestialobject)
        {
            _ctx.Add(celestialobject);
        }

        public void AddDiscoverySource( DiscoverySource discoverySource)
        {
            
            _ctx.DiscoverySources.Add(discoverySource);
        }

        public IEnumerable<CelestialObject> GetCelestialObjects()
        {
           return _ctx.CelestialObjects.ToList();
        }

        public IEnumerable<CelestialObject> GetCelestialObjectsByName(string name)
        {
            var result = _ctx.CelestialObjects.Where(n => n.Name == name);
            return result.ToList();
        }

        public IEnumerable<DiscoverySource> GetDiscoverySource()
        {
           return _ctx.DiscoverySources.ToList();
        }

        public IEnumerable<CelestialObject> GetObjectByCountry(string country)
        {
            throw new NotImplementedException();
            
        }

        public IEnumerable<CelestialObject> GetCelestialObjectbyType(string type)
        {
            var result = _ctx.CelestialObjects.Where(a => a.Type == type);

            return result.ToList();
        }

        public void Save()
        {
            _ctx.SaveChanges();
        }
    }
}
