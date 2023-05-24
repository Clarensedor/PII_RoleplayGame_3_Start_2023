using System;
using RoleplayGame;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            SpellsBook book = new SpellsBook();
            book.AddSpell(new SpellOne());
            book.AddSpell(new SpellOne());

            Sword escalibur = new Sword();
            Axe escalibur2 = new Axe();
            Sword escalibur3 = new Sword();
            Sword escalibur4 = new Sword();
            Axe escalibur5 = new Axe();

            // preguntar si se puede en add item poder agregar, muchos items
            // a la vez

            Knight ElZorro = new Knight ("El Zorro");      
            Bow bow = new Bow();
            ElZorro.AddItem(bow);
            
            Knight arturo = new Knight("arturo");
            arturo.AddItem(escalibur);

            Saruman saruman = new Saruman("saruman", 30);

            Console.WriteLine($"La vida de Saruman es {saruman.Health}");
            saruman.ReceiveAttack(arturo);
            Console.WriteLine($"Ahora la vida de Saruman es {saruman.Health}");
            Console.WriteLine($"Los Vp de Arturo son {arturo.Vp}");

            arturo.AddItem(escalibur2);
            arturo.AddItem(escalibur3);
            arturo.AddItem(escalibur4);
            arturo.AddItem(escalibur5);
            saruman.ReceiveAttack(arturo);

            Console.WriteLine($"La vida de Saruman es {saruman.Health}");
            Console.WriteLine($"Los Vp de Arturo son {arturo.Vp}");

        }
    }
}
