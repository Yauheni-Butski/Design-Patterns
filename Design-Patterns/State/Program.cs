using System;
using State.Model;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Weapon weapon = new Weapon(10, 5);

            Console.WriteLine("Welcom to Shooting Range! Shoot into invisible ducks!");
            Console.WriteLine("SpaceBar - Shot. R - Reload");
            while (true)
            {
                var keyPressed = Console.ReadKey(true);

                switch (keyPressed.Key)
                {
                    case ConsoleKey.Spacebar:
                        weapon.Shot();
                        break;
                    case ConsoleKey.R:
                        weapon.Reload();
                        break;
                }
            }
        }
    }
}
