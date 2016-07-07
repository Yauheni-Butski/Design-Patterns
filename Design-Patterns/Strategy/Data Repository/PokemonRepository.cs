using System;
using System.Collections.Generic;
using Strategy.Context;

namespace Strategy.Data_Repository
{
    public class PokemonRepository
    {
        private readonly List<Pokemon> _pokemons;
        private readonly Random _randomizer;

        public PokemonRepository()
        {
            _randomizer = new Random();
            _pokemons = new List<Pokemon>()
            {
                new WaterPokemon("Psyduck", 115, 85, 18, 45, PokemonSexType.Male, true),
                new FirePokemon("Chermonder", 70, 56, 20, 80, PokemonSexType.Male, true),
                new ElectricPokemon("Pikachy", 150, 50, 15, 75, PokemonSexType.Female, false),
                new FirePokemon("Cherizard", 230, 120, 25, 43, PokemonSexType.Female, false),
                new WaterPokemon("Firby", 20, 25, 50, 10, PokemonSexType.Male, true)
            };
        }

        public Pokemon GetRandomPokemon()
        {
            var newsCount = _pokemons.Count;
            var newsIndex = _randomizer.Next(newsCount);

            return _pokemons[newsIndex];
        }
    }
}
