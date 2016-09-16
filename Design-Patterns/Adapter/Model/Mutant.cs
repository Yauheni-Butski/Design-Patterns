using Adapter.Model.Interface;

namespace Adapter.Model
{
    public abstract class Mutant : IMutant 
    {
        public string Name { get; }
        public int CurrentHealth { get; protected set; }

        protected int MaxHealth { get; set; }

        protected Mutant(string name, int health)
        {
            Name = name;
            CurrentHealth = health;
            MaxHealth = health;
        }

        public abstract void Hit();

        public abstract void Mutate();

        public void RegenerateHealth()
        {
            CurrentHealth = MaxHealth;
        }
    }
}
