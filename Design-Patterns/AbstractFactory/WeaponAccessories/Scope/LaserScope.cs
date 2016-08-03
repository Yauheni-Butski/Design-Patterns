using AbstractFactory.WeaponAccessories.Interface;

namespace AbstractFactory.WeaponAccessories.Scope
{
    public class LaserScope : IScope
    {
        private const string Name = "Laser Scope";

        public string GetName()
        {
            return Name;
        }
    }
}
