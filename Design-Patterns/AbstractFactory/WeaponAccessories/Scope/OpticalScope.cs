using AbstractFactory.WeaponAccessories.Interface;

namespace AbstractFactory.WeaponAccessories.Scope
{
    public class OpticalScope : IScope
    {
        private const string Name = "Optical Scope";

        public string GetName()
        {
            return Name;
        }
    }
}
