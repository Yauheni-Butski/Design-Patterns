using System;
using Strategy.Context;
using Strategy.Strategy.Interface;

namespace Strategy.Strategy
{
    public class WeightValidationRule : ICombatSuitabilityValidationRule
    {
        public void ValidateCombatSutiability(Pokemon p)
        {
            if (p.Weight <= 15)
            {
                var message = string.Format("WeightValidationRule: {0} have weight({1}) less then 15 and it is good choice for battle", p.Name, p.Age);
                Console.WriteLine(message);
            }
            else
            {
                var message = string.Format("WeightValidationRule: {0} have weight({1}) more then 15 - it is NOT good choice for battle", p.Name, p.Age);
                Console.WriteLine(message);
            }
        }
    }
}
