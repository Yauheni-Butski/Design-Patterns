using System;

namespace Strategy.Context
{
    public class ElectricPokemon : Pokemon
    {
        public ElectricPokemon(string name, float height, float weight, int age, int strength, PokemonSexType sex, bool isActive) 
                          : base(name, height, weight, age, strength, sex, isActive)
        {

        }

        public override void Attack()
        {
            var message = string.Format("{0} is attacking with electricity.", this.Name);
            Console.WriteLine(message);
        }

        public override void Evolution()
        {
            var message = string.Format("{0} is evolving to next electric type.", this.Name);
            Console.WriteLine(message);
        }
    }
}