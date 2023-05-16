using RoleplayGame;
using System.Collections.Generic;

namespace RoleplayGame
{
    public abstract class Heroes : Character
    {
        private int health = 100;

        private int vp;

        private List<IItem> items = new List<IItem>();

        public Heroes(string name) : base(name)
        {
            this.vp=0;
            this.AddItem(new Bow());
            this.AddItem(new Helmet());
        }

        public void ReceiveAttack(Enemies whoAttack)
        {
            if (this.DefenseValue < whoAttack.AttackValue)
            {
                this.Health -= whoAttack.AttackValue - this.DefenseValue;

            }
        }
        public int Vp
        {
            get
            {
                return this.vp;
            }
            protected internal set
            {
                this.vp = value;
            }
        }

    }
}