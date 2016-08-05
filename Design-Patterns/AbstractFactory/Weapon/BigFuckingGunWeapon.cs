using AbstractFactory.Factory.Interface;

namespace AbstractFactory.Weapon
{
    public class BigFuckingGunWeapon : Base.Weapon
    {
        private readonly IWeaponAccessoryFactory _weaponFactory;

        public BigFuckingGunWeapon(string name, IWeaponAccessoryFactory weaponFactory) : base(name)
        {
            _weaponFactory = weaponFactory;
        }

        public override void Prepare()
        {
            Ammo = _weaponFactory.CreateAmmo();
            Barrel = _weaponFactory.CreateBarrel();
            Bayonet = _weaponFactory.CreateBayonet();
            Butt = _weaponFactory.CreateButt();
            Scope = _weaponFactory.CreateScope();
            Silencer = _weaponFactory.CreateSilencer();
            Stock = _weaponFactory.CreateStock();
            UnderBarrel = _weaponFactory.CreateUnderBarrel();
        }
    }
}
