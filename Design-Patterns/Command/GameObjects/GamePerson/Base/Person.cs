using Command.GameObjects.GameWeapon.Base;
using Command.GameObjects.PersonBehaviour;

namespace Command.GameObjects.GamePerson.Base
{
    public abstract class Person
    {
        public int XPosition { get; set; }
        public int YPosition { get; set; }
        public Weapon Weapon { get; set; }

        private readonly MovementSystem _movementSystem = new MovementSystem();

        protected Person(Weapon weapon, int xPosition = 0, int yPosition = 0)
        {
            Weapon = weapon;
            XPosition = xPosition;
            YPosition = yPosition;
        }

        public void GoLeft()
        {
            _movementSystem.GoLeft(this);
        }

        public void GoRight()
        {
            _movementSystem.GoRight(this);
        }

        public void GoUp()
        {
            _movementSystem.GoUp(this);
        }

        public void GoDown()
        {
            _movementSystem.GoDown(this);
        }
    }
}
