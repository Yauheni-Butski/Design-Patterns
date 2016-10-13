namespace Iterator.Models
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

    public class Building
    {
        public string StreetName { get; }
        public int BuildingNumber { get; }
        public BuildingType BuildingType { get; }

        public Building(string streetName, int buildingNumber, BuildingType buildingType)
        {
            StreetName = streetName;
            BuildingNumber = buildingNumber;
            BuildingType = buildingType;
        }
    }
}
