using AbstractFactory.WeaponAccessories.Interface;

namespace AbstractFactory.WeaponAccessories.Barrel
{
    public class ShipCannonBarrel : IBarrel
    {
        private const string Name = "Big Ship Cannon Barrel";

        public string GetName()
        {
            return Name;
        }
    }
}
