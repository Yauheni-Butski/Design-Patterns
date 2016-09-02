using System;
using System.Collections.Generic;

using Command.Command;
using Command.Command.Base;
using Command.GameObjects.Controller;
using Command.GameObjects.GamePerson;
using Command.GameObjects.GameWeapon;
using Command.GameObjects.GameWeapon.Base;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Create a hero in game by whom we will play
            Weapon superWeapon = new ShotGun(10, "Super Shot Gun");
            var superMan = new Hero("Clark Kent", 100, superWeapon);

            //2. Create commands for managing hero
            ICommand moveUp = new MoveUpCommand(superMan);
            ICommand moveDown = new MoveDownCommand(superMan);
            ICommand moveLeft = new MoveLeftCommand(superMan);
            ICommand moveRight = new MoveRightCommand(superMan);
            ICommand weaponShot = new WeaponShotCommand(superMan.Weapon);
            ICommand weaponReload = new WeaponReloadCommand(superMan.Weapon);
            //2.1 Create macrocommand for super attack
            var superCycleAttackSteps = new List<ICommand>()
            {
                moveUp,
                weaponShot,
                moveRight,
                weaponShot,
                moveDown,
                weaponShot,
                moveLeft,
                weaponShot
            };
            ICommand superCycleAttack = new MacroCommand(superCycleAttackSteps);

            //3. Create XBoxController for game and bind keys with needed actions/commands
            XBoxController xBoxController = new XBoxController(moveUp, moveDown, moveLeft, moveRight, weaponShot, weaponReload, superCycleAttack);

            //4. Let's play. Pushing on the button
            Console.WriteLine("Greetings " + superMan.Name);
            while (true)
            {
              var keyPressed = Console.ReadKey(true);
              xBoxController.KeyInputHandler(keyPressed);
            }
        }
    }
}
