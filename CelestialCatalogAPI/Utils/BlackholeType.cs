using CelestialCatalogAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CelestialCatalogAPI.Extensions
{
    public class BlackholeType : IClasifyObject
    {
        private const double LightSpeed = 299792458;
        
        public void SetObjectType(CelestialObject celestialObject)
        {
            if (celestialObject.EquatorialDiameter / 2 < (2 * (6.67 * Math.Pow(10, -11)) * celestialObject.Mass) / (LightSpeed * LightSpeed))
            {
                celestialObject.Type = "Blackhole";
            }
        }
    }
}
