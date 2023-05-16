using System.Collections.Generic;
namespace RoleplayGame
{
    public class Knight: Heroes, ICharacter
    {
        public Knight(string name) : base(name)
        {
            this.Name = name;
        }
    }
}

