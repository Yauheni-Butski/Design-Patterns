using System;
using System.Timers;

using State.Model;
using State.State.Base;

namespace State.State
{
    public class OverheatedState : WeaponState
    {
        private DateTime _dueTime;

        public OverheatedState(Weapon weapon) : base(weapon)
        {
        }

        public override void Shot()
        {
            var timeForWaiting = (_dueTime - DateTime.Now).TotalSeconds;
            var message = $"You can't shot! Your weapon is overheated! Wait {timeForWaiting} more seconds!";

            Console.WriteLine(message);
        }

        public override void Reload()
        {
            var timeForWaiting = (_dueTime - DateTime.Now).TotalSeconds;
            var message = $"You can't shot! Your weapon is overheated and too hot! Wait {timeForWaiting} more seconds!";

            Console.WriteLine(message);
        }

        public override void Cool()
        {
            //Change state only after 10 seconds were passed
            SetTimer(10000);
        }

        private void SetTimer(double millisecondsInterval)
        {
            var timer = new Timer(millisecondsInterval);

            timer.Elapsed += OnTimedEvent;
            _dueTime = DateTime.Now.AddMilliseconds(millisecondsInterval);
            timer.Start();
        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            Weapon.CurrentState = Weapon.CurrentAmmo > 0
                ? Weapon.LoadedState
                : Weapon.UnloadedState;

            Weapon.ShotsLeftBeforeOverheated = Weapon.ShotsLimit;

            var timer = (Timer)source;
            timer.Stop();
            timer.Dispose();
        }
    }
}
