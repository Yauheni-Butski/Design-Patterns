using System.Collections.Generic;

using Iterator.Collections.Interface;
using Iterator.Iterators;
using Iterator.Iterators.Interface;
using Iterator.Models;

namespace Iterator.Collections
{
    public class CentralDistrictCatalog : IDistrictCatalog
    {
        private readonly List<Building> _centralDistrictBuildings;
        private readonly string _districtName;

        public CentralDistrictCatalog(string districtName)
        {
            _districtName = districtName;
            _centralDistrictBuildings = new List<Building>();
        }

        public CentralDistrictCatalog(string districtName, List<Building> buildings)
        {
            _districtName = districtName;
            _centralDistrictBuildings = buildings;
        }

        public void AddBuilding(Building building)
        {
            _centralDistrictBuildings.Add(building);
        }

        public void RemoveBuilding(Building building)
        {
            if (_centralDistrictBuildings.Contains(building))
            {
                _centralDistrictBuildings.Remove(building);
            }
        }

        public IIterator CreateIterator()
        {
            return new CentralDistrictIterator(_centralDistrictBuildings);
        }

        public string GetDistrictName()
        {
            return _districtName;
        }
    }
}
