using Command.GameObjects.GamePerson.Base;
using Command.GameObjects.GameWeapon.Base;

namespace Command.GameObjects.GamePerson
{
    public class Hero : Person
    {
        public string Name { get; }
        public int Level { get; }

        public Hero(string name, int level, Weapon weapon) : base(weapon)
        {
            Name = name;
            Level = level;
        }
    }
}
