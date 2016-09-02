using System;

using Command.GameObjects.GameWeapon.Base;

namespace Command.GameObjects.GameWeapon
{
    public class ShotGun : Weapon
    {
        public ShotGun(int maxAmmo, string name) : base(maxAmmo, name)
        {

        }

        public override void MakeShotSound()
        {
           var message = string.Format("BoOom! Ammo ({0})", CurrentAmmo);
           Console.WriteLine(message);
        }
    }
}
