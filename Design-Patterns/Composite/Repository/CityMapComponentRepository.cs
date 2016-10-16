using Composite.Component.Interface;
using Composite.Models;

namespace Composite.Repository
{
    /// <summary>
    /// Test repository for storing and getting information about city elements.
    /// </summary>
    public class CityMapComponentRepository
    {
        public IMapComponent GetCity()
        {
            IMapComponent city = new City("Moscow");

            IMapComponent southernDistrict = new District("Southern Administrative District", 1000);
            IMapComponent centralDistrict = new District("Central Administrative District", 1001);

            IMapComponent streetLenina = new Street("Lenina", StreetType.Street);
                streetLenina.AddComponent(new Building(1, BuildingType.Educational));
                streetLenina.AddComponent(new Building(2, BuildingType.Government));
            IMapComponent streetVitory = new Street("Victory", StreetType.Avenue);
                streetVitory.AddComponent(new Building(23, BuildingType.Industrial));
                streetVitory.AddComponent(new Building(26, BuildingType.Military));
            IMapComponent streetTolstogo = new Street("Tolstogo", StreetType.Street);
                streetTolstogo.AddComponent(new Building(34, BuildingType.Religious));
                streetTolstogo.AddComponent(new Building(37, BuildingType.Residential));
            IMapComponent street9May = new Street("9 of May", StreetType.Avenue);
                street9May.AddComponent(new Building(45, BuildingType.Residential));
                street9May.AddComponent(new Building(47, BuildingType.Residential));
            IMapComponent streetVanDamme = new Street("Jean-Claude Van Damme", StreetType.Alley);
                streetVanDamme.AddComponent(new Building(54, BuildingType.Educational));
                streetVanDamme.AddComponent(new Building(58, BuildingType.Educational));
            IMapComponent streetJackie = new Street("Jackie Chan", StreetType.Boulevard);
                streetJackie.AddComponent(new Building(67, BuildingType.Government));

            IMapComponent streetGhostbusters = new Street("Ghostbusters", StreetType.Street);
                streetGhostbusters.AddComponent(new Building(87, BuildingType.Industrial));
                streetGhostbusters.AddComponent(new Building(88, BuildingType.Military));
            IMapComponent streetFriendship = new Street("Friendship", StreetType.Alley);
                streetFriendship.AddComponent(new Building(91, BuildingType.Religious));
                streetFriendship.AddComponent(new Building(94, BuildingType.Religious));
            IMapComponent streetAvengers = new Street("Avengers", StreetType.Boulevard);
                streetAvengers.AddComponent(new Building(111, BuildingType.Residential));
                streetAvengers.AddComponent(new Building(112, BuildingType.Educational));
            IMapComponent streetRussian = new Street("Russian", StreetType.Boulevard);
                streetRussian.AddComponent(new Building(221, BuildingType.Government));
                streetRussian.AddComponent(new Building(225, BuildingType.Military));
            IMapComponent streetDonatello = new Street("Donatello", StreetType.Alley);
                streetDonatello.AddComponent(new Building(323, BuildingType.Religious));
            IMapComponent streetLeonardo = new Street("Leonardo", StreetType.Avenue);
                streetLeonardo.AddComponent(new Building(435, BuildingType.Residential));

            southernDistrict.AddComponent(streetLenina);
            southernDistrict.AddComponent(streetVitory);
            southernDistrict.AddComponent(streetTolstogo);
            southernDistrict.AddComponent(street9May);
            southernDistrict.AddComponent(streetVanDamme);
            southernDistrict.AddComponent(streetJackie);

            centralDistrict.AddComponent(streetGhostbusters);
            centralDistrict.AddComponent(streetFriendship);
            centralDistrict.AddComponent(streetAvengers);
            centralDistrict.AddComponent(streetRussian);
            centralDistrict.AddComponent(streetDonatello);
            centralDistrict.AddComponent(streetLeonardo);

            city.AddComponent(southernDistrict);
            city.AddComponent(centralDistrict);

            return city;
        }
    }
}
