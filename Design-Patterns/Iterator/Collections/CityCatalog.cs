using System;
using System.Collections.Generic;

using Iterator.Collections.Interface;
using Iterator.Iterators.Interface;
using Iterator.Models;

namespace Iterator.Collections
{
    public class CityCatalog
    {
        private readonly IList<IDistrictCatalog> _districtCatalogs;
        
        public string CityName { get; }

        public CityCatalog(string cityName, IList<IDistrictCatalog> districtCatalogs)
        {
            CityName = cityName;
            _districtCatalogs = districtCatalogs;
        }

        public void PrintCityCatalog()
        {
            var cityMessage = string.Format("== {0} ==", CityName);
            Console.WriteLine(cityMessage);

            foreach (var district in _districtCatalogs)
            {
                var districtMessage = string.Format("***{0}", district.GetDistrictName());
                Console.WriteLine(districtMessage);

                var districtIterator = district.CreateIterator();
                PrintCityCatalog(districtIterator);
            }
        }

        private void PrintCityCatalog(IIterator iterator)
        {
            while (iterator.HasNext())
            {
                var building = (Building)iterator.Next();

                var buildingMessage = string.Format("{0}, {1}, {2}", building.StreetName, building.BuildingNumber, building.BuildingType);
                Console.WriteLine(buildingMessage);
            }
        }
    }
}
