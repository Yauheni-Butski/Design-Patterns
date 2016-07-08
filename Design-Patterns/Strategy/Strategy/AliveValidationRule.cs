using System;
using Strategy.Context;
using Strategy.Strategy.Interface;

namespace Strategy.Strategy
{
    public class AliveValidationRule : ICombatSuitabilityValidationRule
    {
        public void ValidateCombatSutiability(Pokemon p)
        {
            if (p.IsActive)
            {
                var message = string.Format("AliveValidationRule: {0} alive and it is good choice for battle", p.Name);
                Console.WriteLine(message);
            }
            else
            {
                var message = string.Format("AliveValidationRule: {0} dead and it is NOT good choice for battle", p.Name);
                Console.WriteLine(message);
            }
        }
    }
}