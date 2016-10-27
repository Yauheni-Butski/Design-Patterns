using State.State;
using State.State.Interface;

namespace State.Model
{
    public class Weapon
    {
        public int MaxAmmo { get; }
        public int ShotsLimit { get; }
        public IWeaponState LoadedState { get; }
        public IWeaponState UnloadedState { get; }
        public IWeaponState OverheatedState { get; }

        public int CurrentAmmo { get; set; }
        public IWeaponState CurrentState { get; set; }
        public int ShotsLeftBeforeOverheated { get; set; }

        public Weapon(int maxAmmo, int shotsLimit)
        {
            MaxAmmo = CurrentAmmo = maxAmmo;
            ShotsLimit = ShotsLeftBeforeOverheated = shotsLimit;

            LoadedState = new LoadedState(this);
            UnloadedState = new UnloadedState(this);
            OverheatedState = new OverheatedState(this);

            CurrentState = LoadedState;
        }

        public void SetState(IWeaponState state)
        {
            CurrentState = state;
        }

        public void Shot()
        {
            CurrentState.Shot();
        }

        public void Reload()
        {
            CurrentState.Reload();
        }
        
    }
}
