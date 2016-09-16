using System;

using Adapter.Model.Interface;

namespace Adapter.Model
{
    public class WaterPokemon : IPokemon
    {
        public void Attack()
        {
            var message = string.Format("Water pokemon is attacking with water.");
            Console.WriteLine(message);
        }

        public void Evolve()
        {
            var message = string.Format("Water pokemon is evolving into next water type.");
            Console.WriteLine(message);
        }
    }
}