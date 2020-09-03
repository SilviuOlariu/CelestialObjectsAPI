using CelestialCatalogAPI.Contexts;
using CelestialCatalogAPI.Entities;
using CelestialCatalogAPI.Extensions;
using CelestialCatalogAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CelestialCatalogAPI.Services
{
    public class CatalogRepository : ICatalogRepository
    {
        private readonly CelestialCatalogContext _ctx;
        public CatalogRepository(CelestialCatalogContext ctx)
        {
            _ctx = ctx;
        }

        public void AddCelestialObject(CelestialObject celestialobject)
        {
            _ctx.CelestialObjects.Add(celestialobject);
        }

        public void AddDiscoverySource( DiscoverySource discoverySource)
        {
            
            _ctx.DiscoverySources.Add(discoverySource);
        }

        public IEnumerable<CelestialObject> GetCelestialObjects()
        { 
            var result = _ctx.CelestialObjects.Include(a => a.DiscoverySource).ToList();
            return result;
        }

        public IEnumerable<CelestialObject> GetCelestialObjectsByName(string name)
        {
            var result = _ctx.CelestialObjects.Where(n => n.Name == name).Include(a => a.DiscoverySource);
            return result.ToList();
        }

        public IEnumerable<DiscoverySource> GetDiscoverySource()
        {
           return _ctx.DiscoverySources.ToList();
        }

        public IEnumerable<CelestialObject> GetObjectByCountry(string country)
        {
            var celestialObjects = _ctx.CelestialObjects.Where( a => a.DiscoverySource.StateOwner == country).Include(a => a.DiscoverySource);

            return celestialObjects.ToList();
            
        }

        public IEnumerable<CelestialObject> GetCelestialObjectbyType(string type)
        {
            var result = _ctx.CelestialObjects.Where(a => a.Type == type).Include(a =>a.DiscoverySource);

            return result.ToList();
        }

        public void Save()
        {
            _ctx.SaveChanges();
        }
    }
}
