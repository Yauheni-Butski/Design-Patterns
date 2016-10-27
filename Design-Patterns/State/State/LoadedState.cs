using System;

using State.Model;
using State.State.Base;

namespace State.State
{
    public class LoadedState : WeaponState
    {
        public LoadedState(Weapon weapon) : base(weapon)
        {

        }

        public override void Shot()
        {
            if (Weapon.CurrentAmmo > 0)
            {
                if (Weapon.ShotsLeftBeforeOverheated > 0 && Weapon.ShotsLeftBeforeOverheated <= Weapon.ShotsLimit)
                {
                    Weapon.CurrentAmmo--;
                    Weapon.ShotsLeftBeforeOverheated--;

                    var message = $"Boom! (Current ammo: {Weapon.CurrentAmmo})";
                    Console.WriteLine(message);
                }
                else
                {
                    Weapon.CurrentState = Weapon.OverheatedState;
                    Console.WriteLine("Weapon is overheated!");
                    Weapon.CurrentState.Cool();
                }
            }
            else
            {
                Weapon.CurrentState = Weapon.UnloadedState;
                Console.WriteLine("Run out of ammo!");
            }
        }

        public override void Reload()
        {
            if (Weapon.CurrentAmmo < Weapon.MaxAmmo)
            {
                Weapon.CurrentAmmo = Weapon.MaxAmmo;

                var message = $"Ammo have been restored! (Current ammo: {Weapon.CurrentAmmo})";
                Console.WriteLine(message);
            }
            else
            {
                Console.WriteLine("Your ammo is already full!");
            }
        }

        public override void Cool()
        {
            Console.WriteLine("Your weapon doesn't need cooling");
        }
    }
}
