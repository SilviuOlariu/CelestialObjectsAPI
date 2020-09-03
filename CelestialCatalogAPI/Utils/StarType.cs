using CelestialCatalogAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CelestialCatalogAPI.Extensions
{
    public class StarType : IClasifyObject
    {
        private const double SurfaceReference = 2500;
        public void SetObjectType(CelestialObject celestialObject)
        {
            if (celestialObject.SurfaceTemperature > SurfaceReference)
            {
                celestialObject.Type = "Star";
            };
        }
    }
}
