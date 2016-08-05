using AbstractFactory.WeaponAccessories.Interface;

namespace AbstractFactory.WeaponAccessories.Ammo
{
    public class PlasmaAmmo : IAmmo
    {
        private const string Name = "Plasma Ammo";

        public string GetName()
        {
            return Name;
        }
    }
}
