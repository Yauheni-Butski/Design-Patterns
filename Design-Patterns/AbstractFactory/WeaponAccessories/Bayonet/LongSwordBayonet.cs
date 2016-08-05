using AbstractFactory.WeaponAccessories.Interface;

namespace AbstractFactory.WeaponAccessories.Bayonet
{
    public class LongSwordBayonet : IBayonet
    {
        private const string Name = "Long Sword Bayonet";

        public string GetName()
        {
            return Name;
        }
    }
}
