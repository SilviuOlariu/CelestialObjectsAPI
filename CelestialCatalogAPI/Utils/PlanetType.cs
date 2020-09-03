using CelestialCatalogAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CelestialCatalogAPI.Extensions
{
    public class PlanetType : IClasifyObject
    {
        private readonly static double MassReference = 13 * 1.898 * Math.Pow(10, 27);
        public void SetObjectType(CelestialObject celestialObject)
        {
            if (celestialObject.Mass <= MassReference)
            {
                celestialObject.Type = "Planet";
            }
        }
    }
}
