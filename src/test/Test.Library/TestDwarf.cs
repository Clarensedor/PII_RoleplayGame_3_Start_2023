using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    public class DwarfTests
    {

        [Test]
        public void Valor_ataque1()
        {
            const int expected = 25; //porque el dwarf ya viene con un axe 
            Dwarf enano = new Dwarf ("Pitufo");
            Assert.AreEqual(expected, enano.AttackValue);
        }

        [Test]
        public void Valor_defensa1()
        {
            const int expected = 18;
            Dwarf enano = new Dwarf ("Pitufo");
            Assert.AreEqual(expected, enano.DefenseValue);
        }

        [Test]
        public void Vida_inicial1()
        {
            const int expected = 100;
            Dwarf enano = new Dwarf ("Pitufo");
            Assert.AreEqual(expected, enano.Health);
        }

        [Test]
        public void DefenseValue_Modified_By_AddingItem1()      //Prueba que el metodo AddItem modifica el valor de defensa
        {
            Dwarf enano = new Dwarf ("Pitufo");      //Tiene 18 de defensa 
            Staff staff = new Staff(); //100
            enano.AddItem(staff);  
            int expectedDefenseValue = 118; //Pues Dwarf ya viene con Helmet que le da 18 de defenseValue
            Assert.AreEqual(expectedDefenseValue, enano.DefenseValue);
        }

                [Test]
        public void AttackValue_Modified_By_AddingItem1()      //Prueba que el metodo AddItem modifica el valor de ataque
        {
            Dwarf lego = new Dwarf ("Lego");      // viene con 25 de ataque por el axe
            Staff staff = new Staff(); //le agrega 100 de ataque
            lego.AddItem(staff);
            int expectedAttackValue = 125;      
            Assert.AreEqual(expectedAttackValue, lego.AttackValue);
        }


    }
}