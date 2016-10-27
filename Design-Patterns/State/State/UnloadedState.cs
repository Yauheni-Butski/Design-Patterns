using System;

using State.Model;
using State.State.Base;

namespace State.State
{
    public class UnloadedState : WeaponState
    {
        public UnloadedState(Weapon weapon) : base(weapon)
        {
        }
        public override void Shot()
        {
            Console.WriteLine("You can't shot! You don't have ammo!");
        }

        public override void Reload()
        {
            Weapon.CurrentAmmo = Weapon.MaxAmmo;
            Weapon.CurrentState = Weapon.LoadedState;

            var message = $"Ammo have been restored! (Current ammo: {Weapon.CurrentAmmo})";
            Console.WriteLine(message);
        }

        public override void Cool()
        {
            Console.WriteLine("Your weapon doesn't need cooling");
        }
    }
}
