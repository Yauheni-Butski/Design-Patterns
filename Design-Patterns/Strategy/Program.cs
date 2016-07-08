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
            pokemon1.SetCombatSutiabilityValidationRule(new BigHeightValidationRule());
            pokemon1.CheckCombatSuitability();

            var pokemon2 = pokemonRepository.GetRandomPokemon();
            pokemon2.CheckCombatSuitability();
            pokemon2.SetCombatSutiabilityValidationRule(new StrengthValidationRule());
            pokemon2.CheckCombatSuitability();

            var pokemon3 = pokemonRepository.GetRandomPokemon();
            pokemon3.CheckCombatSuitability();
            pokemon3.SetCombatSutiabilityValidationRule(new YoungMaleValidationRule());
            pokemon3.CheckCombatSuitability();

            var pokemon4 = pokemonRepository.GetRandomPokemon();
            pokemon4.CheckCombatSuitability();
            pokemon4.SetCombatSutiabilityValidationRule(new WeightValidationRule());
            pokemon4.CheckCombatSuitability();
        }
    }
}
