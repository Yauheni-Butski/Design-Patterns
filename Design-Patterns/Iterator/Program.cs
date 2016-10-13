using System.Collections.Generic;

using Iterator.Collections;
using Iterator.Collections.Interface;
using Iterator.Models;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Create district catalogs
            var southernCatalog = new SouthernDistrictCatalog("Southern Administrative District");
            southernCatalog.AddBuilding(new Building("Lenina street", 1, BuildingType.Residential));
            southernCatalog.AddBuilding(new Building("Lenina street", 2, BuildingType.Religious));
            southernCatalog.AddBuilding(new Building("Victory avenue", 25, BuildingType.Government));
            southernCatalog.AddBuilding(new Building("Tolstogo street", 10, BuildingType.Industrial));
            southernCatalog.AddBuilding(new Building("Tolstogo street", 15, BuildingType.Educational));
            southernCatalog.AddBuilding(new Building("9 of May avenue", 18, BuildingType.Religious));

            var centralCatalog = new CentralDistrictCatalog("Central Administrative District");
            centralCatalog.AddBuilding(new Building("Ghostbusters street", 25, BuildingType.Military));
            centralCatalog.AddBuilding(new Building("Ghostbusters street", 30, BuildingType.Educational));
            centralCatalog.AddBuilding(new Building("Friendship avenue", 123, BuildingType.Government));
            centralCatalog.AddBuilding(new Building("Avengers street", 145, BuildingType.Educational));
            centralCatalog.AddBuilding(new Building("Russian street", 78, BuildingType.Military));
            centralCatalog.AddBuilding(new Building("Avengers street", 98, BuildingType.Residential));

            var districts = new List<IDistrictCatalog>()
            {
                southernCatalog,
                centralCatalog
            };

            //2. Create our client
            var cityCatalog = new CityCatalog("Moscow", districts);
            cityCatalog.PrintCityCatalog();
        }
    }
}
