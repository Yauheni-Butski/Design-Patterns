using System.Collections.Generic;

using Iterator.Iterators.Interface;
using Iterator.Models;

namespace Iterator.Iterators
{
    public class CentralDistrictIterator : IIterator
    {
        private readonly List<Building> _centralDistrictBuildings;
        private int _position;

        public CentralDistrictIterator(List<Building> centralDistrictBuildings)
        {
            _centralDistrictBuildings = centralDistrictBuildings;
        }
        public bool HasNext()
        {
            return _position <= _centralDistrictBuildings.Count - 1;
        }

        public object Next()
        {
            var building = _centralDistrictBuildings[_position];
            _position++;
            return building;
        }
    }
}
