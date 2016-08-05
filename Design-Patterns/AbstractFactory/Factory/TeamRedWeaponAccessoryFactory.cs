using AbstractFactory.Factory.Interface;
using AbstractFactory.WeaponAccessories.Ammo;
using AbstractFactory.WeaponAccessories.Barrel;
using AbstractFactory.WeaponAccessories.Bayonet;
using AbstractFactory.WeaponAccessories.Butt;
using AbstractFactory.WeaponAccessories.Interface;
using AbstractFactory.WeaponAccessories.Scope;
using AbstractFactory.WeaponAccessories.Silencer;
using AbstractFactory.WeaponAccessories.Stock;
using AbstractFactory.WeaponAccessories.UnderBarrel;

namespace AbstractFactory.Factory
{
    public class TeamRedWeaponAccessoryFactory : IWeaponAccessoryFactory
    {
        public IAmmo CreateAmmo()
        {
            return new BananaAmmo();
        }

        public IScope CreateScope()
        {
            return new LaserScope();
        }

        public IBarrel CreateBarrel()
        {
            return new ShipCannonBarrel();
        }

        public ISilencer CreateSilencer()
        {
            return new LongSpySilencer();
        }

        public IButt CreateButt()
        {
            return new ShortGoldenButt();
        }

        public IUnderBarrel CreateUnderBarrel()
        {
            return new ChainsawUnderBarrel();
        }

        public IStock CreateStock()
        {
            return new MammothTuskStock();
        }

        public IBayonet CreateBayonet()
        {
            return new LongSwordBayonet();
        }
    }
}