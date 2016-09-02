using Command.Command.Base;
using Command.GameObjects.GamePerson.Base;

namespace Command.Command
{
    public class MoveUpCommand : ICommand
    {
        private readonly Person _person;

        public MoveUpCommand(Person person)
        {
            _person = person;
        }

        public void Execute()
        {
            _person.GoUp();
        }

        public void Undo()
        {
            _person.GoDown();
        }
    }
}
