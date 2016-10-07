using System;

using TemplateMethod.Weapon.Base;

namespace TemplateMethod.Weapon
{
    public class HeavyAlienGun : WeaponBase
    {
        public HeavyAlienGun(string name) : base(name)
        {

        }

        protected override void CreateStock()
        {
            Console.WriteLine("Create Adamant Stock");
        }

        protected override void CreateBarrel()
        {
            Console.WriteLine("Create long diamond barrel");
        }

        protected override void CreateAmmo()
        {
            Console.WriteLine("Create Plasma Ammo");
        }

        protected override void CreateUnderBarrel()
        {
            Console.WriteLine("Create Laser Under Barrel");
        }

        protected override void CreateScope()
        {
            Console.WriteLine("Create Laser Scope");
        }

        protected override bool HasScope()
        {
            var message = string.Format("Add a scope to {0}? (Y/N)", Name);
            var answer = AskUserYesOrNo(message);

            return answer;
        }

        protected override bool HasUnderBarrel()
        {
            var message = string.Format("Add an under barrel to {0}? (Y/N)", Name);
            var answer = AskUserYesOrNo(message);

            return answer;
        }

        private bool AskUserYesOrNo(string questionMessage)
        {
            Console.WriteLine(questionMessage);
            var answer = Console.ReadKey();
            Console.WriteLine();

            return answer.KeyChar == 'y';
        }
    }
}
