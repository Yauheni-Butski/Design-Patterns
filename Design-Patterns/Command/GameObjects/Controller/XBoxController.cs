using System;
using System.Collections.Generic;

using Command.Command;
using Command.Command.Base;

namespace Command.GameObjects.Controller
{
    public class XBoxController
    {
        private readonly ICommand _buttonUp;
        private readonly ICommand _buttonDown;
        private readonly ICommand _buttonLeft;
        private readonly ICommand _buttonRigt;

        private readonly ICommand _buttonX;
        private readonly ICommand _buttonY;
        private readonly ICommand _buttonA;

        private readonly Stack<ICommand> _prevCommands;
        private readonly List<ICommand> _saveSlot;

        public XBoxController(ICommand buttonUpAction,
                              ICommand buttonDownAction,
                              ICommand buttonLeftAction, 
                              ICommand buttonRightAction, 
                              ICommand buttonXAction, 
                              ICommand buttonYAction,
                              ICommand buttonAAction)
        {
            _buttonUp = buttonUpAction;
            _buttonDown = buttonDownAction;
            _buttonLeft = buttonLeftAction;
            _buttonRigt = buttonRightAction;

            _buttonX = buttonXAction;
            _buttonY = buttonYAction;
            _buttonA = buttonAAction;

            _prevCommands = new Stack<ICommand> ();
            _prevCommands.Push(EmptyCommand.GetInstance());

            _saveSlot = new List<ICommand>();
        }

        public void KeyInputHandler(ConsoleKeyInfo key)
        {
            switch (key.Key)
            {
                case ConsoleKey.UpArrow:
                    DoAction(_buttonUp);
                    break;
                case ConsoleKey.DownArrow:
                    DoAction(_buttonDown);
                    break;
                case ConsoleKey.LeftArrow:
                    DoAction(_buttonLeft);
                    break;
                case ConsoleKey.RightArrow:
                    DoAction(_buttonRigt);
                    break;
                case ConsoleKey.Spacebar:
                    DoAction(_buttonX);
                    break;
                case ConsoleKey.R:
                    DoAction(_buttonY);
                    break;
                case ConsoleKey.S:
                    DoAction(_buttonA);
                    break;
                case ConsoleKey.U:
                    UndoAction();
                    break;
                case ConsoleKey.F5:
                    SaveGame();
                    break;
                case ConsoleKey.F8:
                    LoadGame();
                    break;
            }
        }

        private void UndoAction()
        {
            if (_prevCommands.Count != 0)
            {
                Console.Write("Undo:");
                var prevCommand = _prevCommands.Pop();
                prevCommand.Undo();
            }
        }

        private void DoAction(ICommand button)
        {
            button.Execute();
            _prevCommands.Push(button);
        }

        private void SaveGame()
        {
            _saveSlot.Clear();
            var prevCommandsArray = _prevCommands.ToArray();

            for (var i = prevCommandsArray.Length - 1; i >= 0; i--)
            {
                _saveSlot.Add(prevCommandsArray[i]);
            }

            Console.WriteLine("Your game was successfully saved!");
        }

        private void LoadGame()
        {
            Console.Clear();

            if (_saveSlot.Count == 0)
            {
                Console.WriteLine("You don't have saved game");
                return;
            }

            _prevCommands.Clear();
            foreach (var command in _saveSlot)
            {
                _prevCommands.Push(command);
                command.Execute();
            }

            Console.WriteLine("Your game was successfully loaded!");
        }
    }
}
