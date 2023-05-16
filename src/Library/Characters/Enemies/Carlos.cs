using RoleplayGame;

namespace RoleplayGame
{
    public class Carlos : Enemies
    {
        private int vp;

        public Carlos(string name) : base(name)
        {
            this.vp = 10;
            this.AddItem(new Staff());
            this.AddItem(new Helmet());
        }
    }
}