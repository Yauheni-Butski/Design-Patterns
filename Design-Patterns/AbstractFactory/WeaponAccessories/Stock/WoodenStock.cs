using AbstractFactory.WeaponAccessories.Interface;

namespace AbstractFactory.WeaponAccessories.Stock
{
    public class WoodenStock : IStock
    {
        private const string Name = "Wooden Stock";

        public string GetName()
        {
            return Name;
        }
    }
}
