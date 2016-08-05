using AbstractFactory.WeaponAccessories.Interface;

namespace AbstractFactory.WeaponAccessories.UnderBarrel
{
    class FlamethrowerUnderBarrel : IUnderBarrel
    {
        private const string Name = "Flamethrower 'From Hell With Love' - 2000";

        public string GetName()
        {
            return Name;
        }
    }
}
