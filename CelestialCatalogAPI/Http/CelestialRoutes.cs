using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CelestialCatalogAPI.Http.CelestialRoutes
{
    public static  class CelestialRoutes
    {
        public const string GetObjects = "api/celestialObject";
        public const string GetObjectsByType = "api/celestialObject/getCelestialObjectsByType";
        public const string GetObjectsByName = "api/celestialObject/GetCelestialObjectByName";
        public const string GetObjectByCountry = "api/celestialObject/GetCelestialObjectByCountry";
    }
}
