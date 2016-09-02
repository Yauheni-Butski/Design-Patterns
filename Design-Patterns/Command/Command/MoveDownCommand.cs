using Command.Command.Base;
using Command.GameObjects.GamePerson.Base;

namespace Command.Command
{
    public class MoveDownCommand : ICommand
    {
        private readonly Person _person;

        public MoveDownCommand(Person person)
        {
            _person = person;
        }

        public void Execute()
        {
            _person.GoDown();
        }

        public void Undo()
        {
            _person.GoUp();
        }
    }
}
