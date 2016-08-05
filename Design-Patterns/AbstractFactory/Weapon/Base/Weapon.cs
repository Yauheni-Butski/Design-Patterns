using System;

using AbstractFactory.Weapon.Interface;
using AbstractFactory.WeaponAccessories.Interface;

namespace AbstractFactory.Weapon.Base
{
    public abstract class Weapon : IWeapon
    {
        public string Name { get; }

        protected IAmmo Ammo;
        protected IBarrel Barrel;
        protected IBayonet Bayonet;
        protected IButt Butt;
        protected IScope Scope;
        protected ISilencer Silencer;
        protected IStock Stock;
        protected IUnderBarrel UnderBarrel;

        protected Weapon(string name)
        {
            Name = name;
        }

        public abstract void Prepare();

        public void Print()
        {
            Prepare();

            string headerMessage = string.Format("Weapon '{0}' :", Name);
            Console.WriteLine(headerMessage);

            if (Ammo != null)
            {
                string ammoMessage = string.Format("Ammo: {0}", Ammo.GetName());
                Console.WriteLine(ammoMessage);
            }
            if (Barrel != null)
            {
                string ammoMessage = string.Format("Barrel: {0}", Barrel.GetName());
                Console.WriteLine(ammoMessage);
            }
            if (Bayonet != null)
            {
                string ammoMessage = string.Format("Bayonet: {0}", Bayonet.GetName());
                Console.WriteLine(ammoMessage);
            }
            if (Butt != null)
            {
                string ammoMessage = string.Format("Butt: {0}", Butt.GetName());
                Console.WriteLine(ammoMessage);
            }
            if (Scope != null)
            {
                string ammoMessage = string.Format("Scope: {0}", Scope.GetName());
                Console.WriteLine(ammoMessage);
            }
            if (Silencer != null)
            {
                string ammoMessage = string.Format("Silencer: {0}", Silencer.GetName());
                Console.WriteLine(ammoMessage);
            }
            if (Stock != null)
            {
                string ammoMessage = string.Format("Stock: {0}", Stock.GetName());
                Console.WriteLine(ammoMessage);
            }
            if (UnderBarrel != null)
            {
                string ammoMessage = string.Format("UnderBarrel: {0}", UnderBarrel.GetName());
                Console.WriteLine(ammoMessage);
            }
        }
    }
}
