using System;

using Adapter.Model.Interface;

namespace Adapter.Model
{
    public class FirePokemon : IPokemon
    {
        public void Attack()
        {
            var message = string.Format("Fire pokemon is attacking with fire.");
            Console.WriteLine(message);
        }

        public void Evolve()
        {
            var message = string.Format("Fire pokemon is evolving into next fire type.");
            Console.WriteLine(message);
        }
    }
}
