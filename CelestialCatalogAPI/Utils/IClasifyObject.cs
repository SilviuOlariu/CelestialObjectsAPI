using CelestialCatalogAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CelestialCatalogAPI.Extensions
{
  public interface IClasifyObject
    {
        void SetObjectType(CelestialObject celestialObject);
    }
}
