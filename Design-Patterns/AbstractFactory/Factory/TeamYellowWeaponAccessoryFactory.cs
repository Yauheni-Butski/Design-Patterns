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
    public class TeamYellowWeaponAccessoryFactory : IWeaponAccessoryFactory
    {
        public IAmmo CreateAmmo()
        {
            return new PlasmaAmmo();
        }

        public IScope CreateScope()
        {
            return new OpticalScope();
        }

        public IBarrel CreateBarrel()
        {
            return new ShortThinMetalBarrel();
        }

        public ISilencer CreateSilencer()
        {
            return new LongSpySilencer();
        }

        public IButt CreateButt()
        {
            return new ShortWoodenButt();
        }

        public IUnderBarrel CreateUnderBarrel()
        {
            return new FlamethrowerUnderBarrel();
        }

        public IStock CreateStock()
        {
            return new WoodenStock();
        }

        public IBayonet CreateBayonet()
        {
            return new LongSwordBayonet();
        }
    }
}
