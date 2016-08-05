using AbstractFactory.WeaponAccessories.Interface;

namespace AbstractFactory.Factory.Interface
{
    public interface IWeaponAccessoryFactory
    {
        ISilencer CreateSilencer();
        IScope CreateScope();
        IButt CreateButt();
        IBarrel CreateBarrel();
        IUnderBarrel CreateUnderBarrel();
        IStock CreateStock();
        IBayonet CreateBayonet();
        IAmmo CreateAmmo();
    }
}