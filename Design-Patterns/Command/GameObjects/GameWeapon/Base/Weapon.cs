using System;

namespace Command.GameObjects.GameWeapon.Base
{
    public abstract class Weapon
    {
        public string Name { get; }
        public int CurrentAmmo { get; private set; }

        private readonly int _maxAmmo;

        protected Weapon(int maxAmmo, string name)
        {
            Name = name;
            _maxAmmo = maxAmmo;
            CurrentAmmo = maxAmmo;
        }

        public void Reload()
        {
            CurrentAmmo = _maxAmmo;

            string message = string.Format("Reload {0}. Ammo ({1})", Name, CurrentAmmo);
            Console.WriteLine(message);
        }

        public void AddCartridge()
        {
            if (CurrentAmmo < _maxAmmo)
            {
                CurrentAmmo++;
            }

            string message = string.Format("Add one cartridge into {0}. Ammo ({1})", Name, CurrentAmmo);
            Console.WriteLine(message);
        }

        public void RemoveMagazine()
        {
            CurrentAmmo = 0;
            string message = string.Format("Magazine was removed from {0}. Ammo ({1})", Name, CurrentAmmo);
            Console.WriteLine(message);
        }

        public void Shot()
        {
            if (CurrentAmmo > 0)
            {
                CurrentAmmo -= 1;
                this.MakeShotSound();
            }
            else
            {
                Console.WriteLine("No Ammo!");
            }
        }

        //Abstract method. Descendant should implement how he will shot
        public abstract void MakeShotSound();

    }
}
