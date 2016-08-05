using System;

using AbstractFactory.Factory;
using AbstractFactory.Factory.Interface;
using AbstractFactory.Weapon;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            IWeaponAccessoryFactory teamRedFactory = new TeamRedWeaponAccessoryFactory();
            Weapon.Base.Weapon teamRedWeapon = new BigFuckingGunWeapon("Team Red BFG Weapon", teamRedFactory);
            teamRedWeapon.Print();
            Console.WriteLine("====================");

            IWeaponAccessoryFactory teamYellowFactory = new TeamYellowWeaponAccessoryFactory();
            Weapon.Base.Weapon teamYellowWeapon = new BigFuckingGunWeapon("Team Yellow BFG Weapon", teamYellowFactory);
            teamYellowWeapon.Print();
            Console.WriteLine("====================");
        }
    }
}
