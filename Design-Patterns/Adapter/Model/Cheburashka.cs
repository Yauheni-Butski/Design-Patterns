using System;

namespace Adapter.Model
{
    public class Cheburashka : Mutant
    {
        public Cheburashka(string name, int health) : base(name, health)
        {

        }

        public override void Hit()
        {
            var message = string.Format("{0} is hitting with Big Ears", this.Name);
            Console.WriteLine(message);
        }

        public override void Mutate()
        {
            this.MaxHealth = this.MaxHealth * 2;
            this.RegenerateHealth();

            var message = string.Format("{0} is mutating into next big type with health {1}", this.Name, this.MaxHealth);
            Console.WriteLine(message);
        }
    }
}
