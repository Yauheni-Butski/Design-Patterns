using AbstractFactory.WeaponAccessories.Interface;

namespace AbstractFactory.WeaponAccessories.Ammo
{
    public class BananaAmmo : IAmmo
    {
        private const string Name = "Banana Ammo";

        public string GetName()
        {
            return Name;
        }
    }
}
