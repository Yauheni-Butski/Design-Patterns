using System;

using Composite.Component;

namespace Composite.Models
{
    public enum BuildingType
    {
        Residential,
        Educational,
        Government,
        Industrial,
        Military,
        Religious
    }

    public class Building : MapComponent
    {
        public int BuildingNumber { get; }
        public BuildingType BuildingType { get; }
        public override int Number => BuildingNumber;
        public override string Type => BuildingType.ToString();

        public Building(int buildingNumber, BuildingType buildingType)
        {
            BuildingNumber = buildingNumber;
            BuildingType = buildingType;
        }

        public override void Show()
        {
            var buildingMessage = string.Format("            Building number #{0}, Type - {1}", BuildingNumber, BuildingType);
            Console.WriteLine(buildingMessage);
        }
    }
}
