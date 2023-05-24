using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    public class Tests_Knight
    {
        [SetUp]
        public void Setup_K()
        {
        }

        [Test]
        public void valor_ataque_K()
        {
            const int expected = 0;
            Knight Quijote  = new Knight ("Quijote ");
            Assert.AreEqual(expected, Quijote.AttackValue);
        }

        [Test]
        public void valor_defensa_K()
        {
            const int expected = 0;
            Knight Quijote  = new Knight ("Quijote ");
            Assert.AreEqual(expected, Quijote.DefenseValue);
        }

        [Test]
        public void vida_inicial_K()
        {
            const int expected = 100;
            Knight Quijote  = new Knight ("Quijote ");
            Assert.AreEqual(expected, Quijote.Health);
        }

        [Test]
        public void DefenseValue_Modified_By_AddingItem_K()      //Prueba que el metodo AddItem modifica el valor de defensa
        {
            Knight Quijote  = new Knight ("Quijote ");      
            Shield shield  = new Shield();
            Helmet helmet = new Helmet(); 
            Quijote .AddItem(helmet);
            Quijote .AddItem(shield);  
            int expectedDefenseValue = 32; 
            Assert.AreEqual(expectedDefenseValue, Quijote.DefenseValue);
        }

                [Test]
        public void AttackValue_Modified_By_AddingItem_K()      //Prueba que el metodo AddItem modifica el valor de ataque
        {
            Knight ElZorro = new Knight ("El Zorro");      
            Bow bow = new Bow();
            ElZorro.AddItem(bow);
            int expectedAttackValue = 15;
            Assert.AreEqual(expectedAttackValue, ElZorro.AttackValue);
        }


    }
}