using System;
using System.Collections.Generic;
using System.Linq;

using Composite.Component;
using Composite.Component.Interface;

namespace Composite.Models
{
    public class City : MapComponent
    {
        private readonly List<IMapComponent> _cityComponents;

        public override string Name { get; }

        public City(string cityName)
        {
            Name = cityName;
            _cityComponents = new List<IMapComponent>();
        }

        public override void Show()
        {
            var cityMessage = string.Format("$$$ City: {0}$$$", Name);
            Console.WriteLine(cityMessage);
            Console.WriteLine();

            foreach (var cityComponent in _cityComponents)
            {
                cityComponent.Show();
            }
        }

        public override void AddComponent(IMapComponent component)
        {
            _cityComponents.Add(component);
        }

        public override IMapComponent FindChildByName(string name)
        {
            var cityComponent = _cityComponents.FirstOrDefault(c => c.Name == name);

            if (cityComponent == null)
            {
                foreach (var child in _cityComponents)
                {
                    cityComponent = child.FindChildByName(name);

                    if (cityComponent != null)
                        break;
                }
            }

            return cityComponent;
        }
    }
}
