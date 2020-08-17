using CelestialCatalogAPI.Entities;
using CelestialCatalogAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CelestialCatalogAPI.Extensions
{
    public static class ObjectClassifier
    {
        private readonly static double LightSpeed = 299792458;
        private readonly static double MassReference = 13 * 1.898 * Math.Pow(10, 27);
        private readonly static double SurfaceReference = 2500;
       

       
        public static void ClassifyObject(this CelestialObjectDto objectDto)
        {
            if (objectDto.EquatorialDiameter / 2 < (2 * (6.67 * Math.Pow(10, -11)) * objectDto.Mass) / (LightSpeed * LightSpeed))
            {
                objectDto.Type = "Blackhole";
            }        
            else
            if(objectDto.Mass <= MassReference)
            {
                objectDto.Type = "Planet";
            }
            else
            if(objectDto.SurfaceTemperature >SurfaceReference)
            {
                objectDto.Type = "Star";
            }
            else
            {
                objectDto.Type = "Unknown";
            }
        }
        
    }
}
