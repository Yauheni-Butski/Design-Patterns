using System.Collections.Generic;

using Iterator.Collections.Interface;
using Iterator.Iterators;
using Iterator.Iterators.Interface;
using Iterator.Models;

namespace Iterator.Collections
{
    public class SouthernDistrictCatalog : IDistrictCatalog
    {
        private readonly Dictionary<string, IList<Building>> _southenDistrictBuildings;
        private readonly string _districtName;

        public SouthernDistrictCatalog(string districtName)
        {
            _districtName = districtName;
            _southenDistrictBuildings = new Dictionary<string, IList<Building>>();
        }

        public SouthernDistrictCatalog(string districtName, IList<Building> buildings)
        {
            _districtName = districtName;
            foreach (var building in buildings)
            {
                AddBuilding(building);
            }
        }

        public void AddBuilding(Building building)
        {
            var streetName = building.StreetName;

            if (!_southenDistrictBuildings.ContainsKey(streetName))
            {
                _southenDistrictBuildings[streetName] = new List<Building>();
            }

            _southenDistrictBuildings[streetName].Add(building);
        }

        public void RemoveBuilding(Building building)
        {
            var streetName = building.StreetName;

            if (_southenDistrictBuildings.ContainsKey(streetName) &&
                _southenDistrictBuildings[streetName].Contains(building))
            {
                _southenDistrictBuildings[streetName].Remove(building);
            }
        }

        public IIterator CreateIterator()
        {
            return new SouthernDistrictIterator(_southenDistrictBuildings);
        }

        public string GetDistrictName()
        {
            return _districtName;
        }
    }
}
