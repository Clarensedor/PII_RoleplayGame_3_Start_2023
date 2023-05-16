using RoleplayGame;

namespace RoleplayGame
{
    public class Testosterona : Enemies
    {
        private int vp;

        public Testosterona(string name) : base(name)
        {
            this.vp = 10;
            this.AddItem(new Staff());
            this.AddItem(new Helmet());
        }


    }
}