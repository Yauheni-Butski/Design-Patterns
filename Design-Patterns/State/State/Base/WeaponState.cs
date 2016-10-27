using State.Model;
using State.State.Interface;

namespace State.State.Base
{
    public abstract class WeaponState : IWeaponState
    {
        protected Weapon Weapon { get; }

        protected WeaponState(Weapon weapon)
        {
            Weapon = weapon;
        }

        public abstract void Shot();
        public abstract void Reload();
        public abstract void Cool();
    }
}
