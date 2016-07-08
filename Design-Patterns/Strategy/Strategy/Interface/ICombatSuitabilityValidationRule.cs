using Strategy.Context;

namespace Strategy.Strategy.Interface
{
    public interface ICombatSuitabilityValidationRule
    {
        void ValidateCombatSutiability(Pokemon p);
    }
}