using System;

using Adapter.Adapter;
using Adapter.Model;
using Adapter.Model.Interface;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pokemon test
            Console.WriteLine("Pokemon test:");
            IPokemon firePokemon = new FirePokemon();
            IPokemon waterPokemon = new WaterPokemon();

            firePokemon.Attack();
            firePokemon.Evolve();
            waterPokemon.Attack();
            waterPokemon.Evolve();

            //Mutant test
            Console.WriteLine("Mutant test:");
            IMutant cheburashka = new Cheburashka("Cheburashka", 100);
            cheburashka.Hit();
            cheburashka.Mutate();

            //Adapt mutant into pokemon
            IPokemon pokeRashka = new MutantAdapter(cheburashka);
            Console.WriteLine("Test using mutant as pokemon:");
            pokeRashka.Attack();
            pokeRashka.Evolve();
        }
    }
}
