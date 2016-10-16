using System;
using System.Collections.Generic;
using System.Linq;

using Composite.Component;
using Composite.Component.Interface;

namespace Composite.Models
{
    public class District : MapComponent
    {
        private readonly List<IMapComponent> _districtComponents;

        public int DistrictCode { get; }
        public string DistrictName { get; }
        public override string Name => DistrictName;
        public override int Code => DistrictCode;

        public District(string districtName, int districtCode)
        {
            DistrictName = districtName;
            DistrictCode = districtCode;
            _districtComponents = new List<IMapComponent>();
        }

        public override void Show()
        {
            var districtMessage = string.Format("====== District: {0}. Code:#{1} ======", DistrictName, DistrictCode);
            Console.WriteLine(districtMessage);
            Console.WriteLine();

            foreach (var districtComponent in _districtComponents)
            {
                districtComponent.Show();
            }
        }

        public override void AddComponent(IMapComponent component)
        {
            _districtComponents.Add(component);
        }

        public override IMapComponent FindChildByName(string name)
        {
            var districtComponent = _districtComponents.FirstOrDefault(c => c.Name == name);

            if (districtComponent == null)
            {
                foreach (var child in _districtComponents)
                {
                    districtComponent = child.FindChildByName(name);

                    if (districtComponent != null)
                        break;
                }
            }

            return districtComponent;
        }
    }
}
