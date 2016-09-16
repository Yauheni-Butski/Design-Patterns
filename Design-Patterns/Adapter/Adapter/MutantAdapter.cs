using Adapter.Model.Interface;

namespace Adapter.Adapter
{
    public class MutantAdapter : IPokemon
    {
        private readonly IMutant _mutant;

        public MutantAdapter(IMutant mutant)
        {
            _mutant = mutant;
        }

        public void Attack()
        {
            _mutant.Hit();
        }

        public void Evolve()
        {
            _mutant.Mutate();
        }
    }
}
