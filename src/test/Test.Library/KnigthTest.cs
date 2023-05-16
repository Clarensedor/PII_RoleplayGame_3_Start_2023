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
            const int expected = 20;
            Knight Quijote  = new Knight ("Quijote ");
            Assert.AreEqual(expected, Quijote.AttackValue);
        }

        [Test]
        public void valor_defensa_K()
        {
            const int expected = 39;
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
            Knight Quijote  = new Knight ("Quijote ");      //Tiene 39 de defensa 
            Helmet helmet = new Helmet(); //18
            Quijote .AddItem(helmet);  
            int expectedDefenseValue = 57; //Pues Knight ya viene con Armor y Shield que le da 39 de defenseValue
            Assert.AreEqual(expectedDefenseValue, Quijote.DefenseValue);
        }

                [Test]
        public void AttackValue_Modified_By_AddingItem_K()      //Prueba que el metodo AddItem modifica el valor de ataque
        {
            Knight ElZorro = new Knight ("El Zorro");      
            Bow bow = new Bow();
            ElZorro.AddItem(bow);
            int expectedAttackValue = 35;
            Assert.AreEqual(expectedAttackValue, ElZorro.AttackValue);
        }


    }
}