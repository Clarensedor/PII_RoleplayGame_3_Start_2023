using RoleplayGame;

namespace RoleplayGame
{
    public abstract class Enemies : Character
    {
        private int vp;
        public Enemies(string name) : base(name)
        {
        }
        public int Vp
        {
            get
            {
                return this.vp;
            }
            private set
            {
                this.vp = value;
            }
        }

        public int ReceiveAttack(Heroes whoAttack)
        {
            if (this.DefenseValue < whoAttack.AttackValue)
            {
                this.Health -= whoAttack.AttackValue - this.DefenseValue;

                if (this.CurrentHealth()<0)
                {
                    whoAttack.Vp+=this.vp;
                }
                return 0;

            }
            else
            {
                return Vp;
            }


        }
    }

}