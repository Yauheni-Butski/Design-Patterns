using TemplateMethod.Weapon;
using TemplateMethod.Weapon.Base;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            WeaponBase alienGun = new HeavyAlienGun("SI-525 Alien");
            alienGun.CreateWeapon();
        }
    }
}
