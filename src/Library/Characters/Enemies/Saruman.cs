using RoleplayGame;

namespace RoleplayGame
{
    public class Saruman : Enemies
    {
        private int vp;

        public Saruman(string name) : base(name)
        {
            this.vp = 25;
            this.AddItem(new Staff());
            this.AddItem(new Helmet());
        }


    }
}