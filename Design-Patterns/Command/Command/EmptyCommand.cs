using System;

using Command.Command.Base;

namespace Command.Command
{
    public sealed class EmptyCommand : ICommand
    {
        private static readonly Lazy<EmptyCommand> Instance = new Lazy<EmptyCommand>(() => new EmptyCommand());

        private EmptyCommand()
        {
            
        }

        public static EmptyCommand GetInstance()
        {
            return Instance.Value;
        }

        public void Execute()
        {

        }

        public void Undo()
        {

        }
    }
}
