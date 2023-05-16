using RoleplayGame;
using System.Collections.Generic;

namespace RoleplayGame
{
    public class Heroes : Character
    {
        
        private int vp;
        public Heroes(string name) : base(name)
        {
            this.vp=0;
        }

        public void ReceiveAttack(int power)
        {
            if (this.DefenseValue < power)
            {
                this.Health -= power - this.DefenseValue;
            }
        }
        public int Vp
        {
            get
            {
                return this.vp;
            }
            set
            {
                this.vp = value;
            }
        }
    }
}
