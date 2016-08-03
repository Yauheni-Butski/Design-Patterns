using AbstractFactory.WeaponAccessories.Interface;

namespace AbstractFactory.WeaponAccessories.Stock
{
    public class MammothTuskStock : IStock
    {
        private const string Name = "Mammonth Tusk Stock";

        public string GetName()
        {
            return Name;
        }
    }
}
