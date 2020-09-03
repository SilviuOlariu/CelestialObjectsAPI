using CelestialCatalogAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CelestialCatalogAPI.Extensions
{
    public  class TypeCalculator
    {
        List<IClasifyObject> _types = new List<IClasifyObject>();

        public TypeCalculator()
        {
            _types.Add( new BlackholeType());
            _types.Add(new StarType());
            _types.Add(new PlanetType());
            
        }

        public void SetCelestialObjectType(CelestialObject celestialObject)
        {
            foreach(var item in _types)
            {
                item.SetObjectType(celestialObject);
            }
            if(celestialObject.Type == null)
            {
                celestialObject.Type = "Unknown";
            }
        }

    }
}
