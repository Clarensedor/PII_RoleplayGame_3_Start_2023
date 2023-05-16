using System.Collections.Generic;
namespace RoleplayGame
{
    public abstract class Character
    {
        
        private int health = 100;

        protected List<IItem> items = new List<IItem>();

        public Character(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public virtual int AttackValue
        {
            get
            {
                int value = 0;
                foreach (IItem item in this.items)
                {
                    if (item is IAttackItem)
                    {
                        value += (item as IAttackItem).AttackValue;
                    }
                }
                return value;
            }
        }

        public int DefenseValue
        {
            get
            {
                int value = 0;
                foreach (IItem item in this.items)
                {
                    if (item is IDefenseItem)
                    {
                        value += (item as IDefenseItem).DefenseValue;
                    }
                }
                return value;
            }
        }

        public int Health
        {
            get
            {
                return this.health;
            }
            protected internal set
            
            {
                this.health = value < 0 ? 0 : value;
            }
        }

        public void Cure()
        {
            this.Health = 100;
        }

        public void AddItem(IItem item)
        {
            this.items.Add(item);
        }

        public void RemoveItem(IItem item)
        {
            this.items.Remove(item);
        }

        public int CurrentHealth()
        {
            if (this.health<0)
            {
                this.health=0;
            }
            return this.health;
        }
    }
}
