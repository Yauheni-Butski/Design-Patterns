using System;

using Command.GameObjects.GamePerson.Base;

namespace Command.GameObjects.PersonBehaviour
{
    public class MovementSystem
    {
        public void GoLeft(Person person)
        {
            person.XPosition -= 1;

            var message = string.Format("Go Left. Position ({0},{1})", person.XPosition, person.YPosition);
            Console.WriteLine(message);
        }

        public void GoRight(Person person)
        {
            person.XPosition += 1;

            var message = string.Format("Go Right. Position ({0},{1})", person.XPosition, person.YPosition);
            Console.WriteLine(message);
        }

        public void GoUp(Person person)
        {
            person.YPosition += 1;


            var message = string.Format("Go Up. Position ({0},{1})", person.XPosition, person.YPosition);
            Console.WriteLine(message);
        }

        public void GoDown(Person person)
        {
            person.YPosition -= 1;

            var message = string.Format("Go Down. Position ({0},{1})", person.XPosition, person.YPosition);
            Console.WriteLine(message);
        }
    }
}
