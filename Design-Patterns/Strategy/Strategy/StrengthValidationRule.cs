using System;
using Strategy.Context;
using Strategy.Strategy.Interface;

namespace Strategy.Strategy
{
    class StrengthValidationRule : ICombatSuitabilityValidationRule
    {
        public void ValidateCombatSutiability(Pokemon p)
        {
            if (p.Strength >= 50)
            {
                var message = string.Format("StrengthValidationRule: {0} have strength({1}) more then 50 and it is good choice for battle", p.Name, p.Height);
                Console.WriteLine(message);
            }
            else
            {
                var message = string.Format("StrengthValidationRule: {0} have strength({1}) less then 50 and he is it is NOT good choice for battle", p.Name, p.Height);
                Console.WriteLine(message);
            }
        }
    }
}
