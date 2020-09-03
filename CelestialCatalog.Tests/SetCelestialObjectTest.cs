using CelestialCatalogAPI.Entities;
using CelestialCatalogAPI.Extensions;
using NUnit.Framework;
using System;

namespace CelestialCatalog.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void SetTypeToBlackhole()
        {
            //arrange
            TypeCalculator calculator = new TypeCalculator();
            CelestialObject celestial = new CelestialObject() 
            {
                Name = "X1 Messier 87",
                Mass = 1.3e40,
                EquatorialDiameter = 11600000,
                SurfaceTemperature = 2000,
                DiscoveryDate = new DateTime(2017 - 12 - 10),
                DiscoverySourceId = 1
            };
            //act
            calculator.SetCelestialObjectType(celestial);

            //asert
            Assert.That(celestial.Type, Is.EqualTo("Blackhole"));
        }

        [Test]
        public void SetTypeToPlanet()
        {
            //arrange
            TypeCalculator calculator = new TypeCalculator();
            CelestialObject celestial = new CelestialObject()
            {
                Name = "OGLE-2005-BLG-390Lb",
                Mass = 3.17237e25,
                EquatorialDiameter = 21557978,
                SurfaceTemperature = 200,
                DiscoveryDate = new DateTime(2017 - 12 - 10),
                DiscoverySourceId = 1
            };
            //act
            calculator.SetCelestialObjectType(celestial);

            //asert
            Assert.That(celestial.Type, Is.EqualTo("Planet"));
        }

        [Test]
        public void SetTypeToStar()
        {
            //arrange
            TypeCalculator calculator = new TypeCalculator();
            CelestialObject celestial = new CelestialObject()
            {
                Name = "V774 Sagittarii",
                Mass = 7.634e31,
                EquatorialDiameter = 1.6710622e10,
                SurfaceTemperature = 5800,
                DiscoveryDate = new DateTime(2017 - 12 - 10),
                DiscoverySourceId = 1
            };
            //act
            calculator.SetCelestialObjectType(celestial);

            //asert
            Assert.That(celestial.Type, Is.EqualTo("Star"));
        }

        [Test]
        public void SetTypeToUnknown()
        {
            //arrange
            TypeCalculator calculator = new TypeCalculator();
            CelestialObject celestial = new CelestialObject()
            {
                Name = "Z0 CVSO 30",
                Mass = 1.2e30,
                EquatorialDiameter = 90000000,
                SurfaceTemperature = 1000,
                DiscoveryDate = new DateTime(2017 - 12 - 10),
                DiscoverySourceId = 1
            };
            //act
            calculator.SetCelestialObjectType(celestial);

            //asert
            Assert.That(celestial.Type, Is.EqualTo("Unknown"));
        }
    }
}