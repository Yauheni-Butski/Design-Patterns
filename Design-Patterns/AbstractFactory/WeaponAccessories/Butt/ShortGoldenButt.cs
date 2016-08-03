using AbstractFactory.WeaponAccessories.Interface;

namespace AbstractFactory.WeaponAccessories.Butt
{
    public class ShortGoldenButt : IButt
    {
        private const string Name = "Short Golden Butt";

        public string GetName()
        {
            return Name;
        }
    }
}
