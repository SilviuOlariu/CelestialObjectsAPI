using CelestialCatalogAPI.Entities;
using CelestialCatalogAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CelestialCatalogAPI.Services
{
  public interface ICatalogRepository
    {
        IEnumerable<CelestialObject> GetCelestialObjects();
        IEnumerable<CelestialObject> GetCelestialObjectbyType(string type);
        IEnumerable<CelestialObject> GetCelestialObjectsByName(string name);
        IEnumerable<CelestialObject> GetObjectByCountry(string country);
        IEnumerable<DiscoverySource> GetDiscoverySource();
        void AddCelestialObject(CelestialObject celestialobject);
        void AddDiscoverySource( DiscoverySource discoverySource);
        void Save();
    }
}
