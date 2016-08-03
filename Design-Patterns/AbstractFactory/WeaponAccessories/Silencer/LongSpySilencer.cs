using AbstractFactory.WeaponAccessories.Interface;

namespace AbstractFactory.WeaponAccessories.Silencer
{
    public class LongSpySilencer : ISilencer
    {
        private const string Name = "Long Spy Silencer";

        public string GetName()
        {
            return Name;
        }
    }
}
