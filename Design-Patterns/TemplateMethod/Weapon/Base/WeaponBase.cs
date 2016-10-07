using System;

namespace TemplateMethod.Weapon.Base
{
    public abstract class WeaponBase
    {
        public string Name { get; }

        protected WeaponBase(string name)
        {
            Name = name;
        }

        public void CreateWeapon()
        {
            CreateStock();
            CreateBarrel();
            JoinBarrelToStock();
            if (HasUnderBarrel())
            {
                CreateUnderBarrel();
                JoinUnderBarrelToBarrel();
            }
            if (HasScope())
            {
                CreateScope();
                JoinScopeToStock();
            }
            CreateAmmo();
            LoadAmmo();
        }

        protected abstract void CreateStock();
        protected abstract void CreateBarrel();
        protected abstract void CreateAmmo();
        protected abstract void CreateUnderBarrel();
        protected abstract void CreateScope();

        protected virtual bool HasUnderBarrel()
        {
            return true;
        }

        protected virtual bool HasScope()
        {
            return true;
        }

        private void JoinBarrelToStock()
        {
            Console.WriteLine("Join barrel to stock...");
        }

        private void LoadAmmo()
        {
            Console.WriteLine("Load ammo to weapon...");
        }

        private void JoinUnderBarrelToBarrel()
        {
            Console.WriteLine("Join underbarrel to barrel...");
        }

        private void JoinScopeToStock()
        {
            Console.WriteLine("Join scope to stock...");
        }
    }
}
