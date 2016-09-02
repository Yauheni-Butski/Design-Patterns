using Command.Command.Base;
using Command.GameObjects.GameWeapon.Base;

namespace Command.Command
{
    class WeaponShotCommand : ICommand
    {
        private readonly Weapon _weapon;

        public WeaponShotCommand(Weapon weapon)
        {
            _weapon = weapon;
        }

        public void Execute()
        {
            _weapon.Shot();
        }

        public void Undo()
        {
            _weapon.AddCartridge();
        }
    }
}
