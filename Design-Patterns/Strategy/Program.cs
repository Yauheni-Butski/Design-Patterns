using Strategy.Data_Repository;
using Strategy.Strategy;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var pokemonRepository = new PokemonRepository();

            var pokemon1 = pokemonRepository.GetRandomPokemon();
            pokemon1.CheckCombatSuitability();
            pokemon1.SetCombatSuitabilityValidationRule(new BigHeightValidationRule());
            pokemon1.CheckCombatSuitability();

            var pokemon2 = pokemonRepository.GetRandomPokemon();
            pokemon2.CheckCombatSuitability();
            pokemon2.SetCombatSuitabilityValidationRule(new StrengthValidationRule());
            pokemon2.CheckCombatSuitability();

            var pokemon3 = pokemonRepository.GetRandomPokemon();
            pokemon3.CheckCombatSuitability();
            pokemon3.SetCombatSuitabilityValidationRule(new YoungMaleValidationRule());
            pokemon3.CheckCombatSuitability();

            var pokemon4 = pokemonRepository.GetRandomPokemon();
            pokemon4.CheckCombatSuitability();
            pokemon4.SetCombatSuitabilityValidationRule(new WeightValidationRule());
            pokemon4.CheckCombatSuitability();
        }
    }
}
