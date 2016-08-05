using AbstractFactory.WeaponAccessories.Interface;

namespace AbstractFactory.WeaponAccessories.Barrel
{
    public class ShortThinMetalBarrel : IBarrel
    {
        private const string Name = "Short Thin Metal Barrel";

        public string GetName()
        {
            return Name;
        }
    }
}
