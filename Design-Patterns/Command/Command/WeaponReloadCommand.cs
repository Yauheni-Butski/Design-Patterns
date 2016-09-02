using Command.Command.Base;
using Command.GameObjects.GameWeapon.Base;

namespace Command.Command
{
    class WeaponReloadCommand : ICommand
    {
        private readonly Weapon _weapon;
        private int _prevAmmoCount;

        public WeaponReloadCommand(Weapon weapon)
        {
            _weapon = weapon;
            _prevAmmoCount = weapon.CurrentAmmo;
        }

        public void Execute()
        {
            _prevAmmoCount = _weapon.CurrentAmmo;
            _weapon.Reload();
        }

        public void Undo()
        {
            _weapon.RemoveMagazine();
            for (var i=0; i <= _prevAmmoCount; i++)
            {
                _weapon.AddCartridge();
            }
        }
    }
}
