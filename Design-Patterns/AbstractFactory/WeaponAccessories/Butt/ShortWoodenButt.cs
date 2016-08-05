using AbstractFactory.WeaponAccessories.Interface;

namespace AbstractFactory.WeaponAccessories.Butt
{
    public class ShortWoodenButt : IButt
    {
        private const string Name = "Short Wooden Butt";

        public string GetName()
        {
            return Name;
        }
    }
}
