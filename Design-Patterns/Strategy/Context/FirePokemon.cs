using System;

namespace Strategy.Context
{
    public class FirePokemon : Pokemon
    {
        public FirePokemon(string name, float height, float weight, int age, int strength, PokemonSexType sex, bool isActive) 
                          : base(name, height, weight, age, strength, sex, isActive)
        {

        }

        public override void Attack()
        {
            var message = string.Format("{0} is attacking with fire.", this.Name);
            Console.WriteLine(message);
        }

        public override void Evolution()
        {
            var message = string.Format("{0} is evolving to next fire type.", this.Name);
            Console.WriteLine(message);
        }
    }
}