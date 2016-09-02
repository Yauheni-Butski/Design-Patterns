using Command.Command.Base;
using Command.GameObjects.GamePerson.Base;

namespace Command.Command
{
    public class MoveRightCommand : ICommand
    {
        private readonly Person _person;

        public MoveRightCommand(Person person)
        {
            _person = person;
        }

        public void Execute()
        {
            _person.GoRight();
        }

        public void Undo()
        {
            _person.GoLeft();
        }
    }
}
