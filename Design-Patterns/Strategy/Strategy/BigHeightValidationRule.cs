using System;
using Strategy.Context;
using Strategy.Strategy.Interface;

namespace Strategy.Strategy
{
    public class BigHeightValidationRule : ICombatSuitabilityValidationRule
    {
        public void ValidateCombatSutiability(Pokemon p)
        {
            if (p.Height >= 120)
            {
                var message = string.Format("BigHeightValidationRule: {0} have height({1}) more then 120 and it is good choice for battle", p.Name, p.Height);
                Console.WriteLine(message);
            }
            else
            {
                var message = string.Format(
                        "BigHeightValidationRule: {0} have height({1}) less then 120 and he is it is NOT good choice for battle",
                        p.Name, p.Height);
                Console.WriteLine(message);
            }
        }
    }
}
