using System.Collections.Generic;
using System.Linq;

using Iterator.Iterators.Interface;
using Iterator.Models;

namespace Iterator.Iterators
{
    public class SouthernDistrictIterator : IIterator
    {
        private readonly Dictionary<string, IList<Building>> _southenDistrictBuildings;
        private int _streetPosition;
        private int _buildingPosition;

        public SouthernDistrictIterator(Dictionary<string, IList<Building>> buildings)
        {
            _southenDistrictBuildings = buildings;
        }

        public bool HasNext()
        {
            if (_streetPosition <= _southenDistrictBuildings.Keys.Count - 1)
            {
                var streetName = _southenDistrictBuildings.Keys.ElementAt(_streetPosition);
                return _buildingPosition <= _southenDistrictBuildings[streetName].Count - 1 ||
                       _streetPosition != _southenDistrictBuildings.Keys.Count - 1;
            }

            return false;
        }

        public object Next()
        {
            var streetName = _southenDistrictBuildings.Keys.ElementAt(_streetPosition);
            var building = _southenDistrictBuildings[streetName][_buildingPosition];

            if (_buildingPosition != _southenDistrictBuildings[streetName].Count - 1)
            {
                _buildingPosition++;
            }
            else
            {
                _buildingPosition = 0;
                _streetPosition++;
            }

            return building;
        }
    }
}
