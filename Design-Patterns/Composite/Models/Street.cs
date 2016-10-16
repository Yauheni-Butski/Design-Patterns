using System;
using System.Collections.Generic;
using System.Linq;

using Composite.Component;
using Composite.Component.Interface;

namespace Composite.Models
{
    public enum StreetType
    {
        Street,
        Alley,
        Avenue,
        Boulevard
    }

    public class Street : MapComponent
    {
        private readonly List<IMapComponent> _streetComponents;

        public string StreetName { get; }
        public StreetType StreetType { get; }
        public override string Name => StreetName;
        public override string Type => StreetType.ToString();

        public Street(string streetName, StreetType streetType)
        {
            StreetName = streetName;
            StreetType = streetType;
            _streetComponents = new List<IMapComponent>();
        }

        public override IMapComponent FindChildByName(string name)
        {
            var streetComponent = _streetComponents.FirstOrDefault(c => c.Name == name);

            return streetComponent;
        }

        public override void AddComponent(IMapComponent component)
        {
            _streetComponents.Add(component);
        }

        public override void Show()
        {
            var streetMessage = string.Format("######### {0} {1}", StreetName, StreetType);
            Console.WriteLine(streetMessage);
            Console.WriteLine();

            foreach (var streetComponent in _streetComponents)
            {
                streetComponent.Show();
            }
        }
    }
}
