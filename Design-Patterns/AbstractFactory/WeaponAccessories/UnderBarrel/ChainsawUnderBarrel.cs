using AbstractFactory.WeaponAccessories.Interface;

namespace AbstractFactory.WeaponAccessories.UnderBarrel
{
    public class ChainsawUnderBarrel : IUnderBarrel
    {
        private const string Name = "Crazy Fucking Chainsaw Barrel CFC-2000";

        public string GetName()
        {
            return Name;
        }
    }
}
