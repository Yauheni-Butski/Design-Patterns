using System;
using Strategy.Context;
using Strategy.Strategy.Interface;

namespace Strategy.Strategy
{
    public class YoungMaleValidationRule : ICombatSuitabilityValidationRule
    {
        public void ValidateCombatSutiability(Pokemon p)
        {
            if (p.Age <= 18 && p.Sex == PokemonSexType.Male)
            {
                var message = string.Format("YoungMaleValidationRule: {0} have age({1}) less then 18 and sex({2}) and it is good choice for battle", p.Name, p.Age, p.Sex);
                Console.WriteLine(message);
            }
            else
            {
                var message = string.Format("YoungMaleValidationRule: {0} have age({1}) more then 18 and sex({2}) - it is NOT good choice for battle", p.Name, p.Age, p.Sex);
                Console.WriteLine(message);
            }
        }
    }
}
