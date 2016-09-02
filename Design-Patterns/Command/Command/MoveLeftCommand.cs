using Command.Command.Base;
using Command.GameObjects.GamePerson.Base;

namespace Command.Command
{
    public class MoveLeftCommand : ICommand
    {
        private readonly Person _person;

        public MoveLeftCommand(Person person)
        {
            _person = person;
        }

        public void Execute()
        {
            _person.GoLeft();
        }

        public void Undo()
        {
            _person.GoRight();
        }
    }
}
