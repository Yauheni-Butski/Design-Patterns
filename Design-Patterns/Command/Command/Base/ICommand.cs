namespace Command.Command.Base
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}