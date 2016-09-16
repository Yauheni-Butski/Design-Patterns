using Strategy.Context.Interface;
using Strategy.Strategy;
using Strategy.Strategy.Interface;

namespace Strategy.Context
{
    public abstract class Pokemon : IPokemonCapability
    {
        public string Name { get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }
        public int Age { get; set; }
        public int Strength { get; set; }
        public PokemonSexType Sex { get; private set; }
        public bool IsActive { get; set; }

        private ICombatSuitabilityValidationRule _combatSutiabilityRule;

        protected Pokemon(string name, float height, float weight, int age, int strength, PokemonSexType sex, bool isActive)
        {
            Name = name;
            Height = height;
            Weight = weight;
            Age = age;
            Strength = strength;
            Sex = sex;
            IsActive = isActive;

            //Set default strategy
            _combatSutiabilityRule = new AliveValidationRule();
        }

        public void SetCombatSutiabilityValidationRule(ICombatSuitabilityValidationRule rule)
        {
            _combatSutiabilityRule = rule;
        }

        public void CheckCombatSuitability()
        {
            _combatSutiabilityRule.ValidateCombatSutiability(this);
        }

        public abstract void Attack();
        public abstract void Evolve();
    }
}
