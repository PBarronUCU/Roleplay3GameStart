
using NUnit.Framework;
using Library.Characters;
using Library.Items;

namespace TestLibrary
{
    [TestFixture]
    public class Test_Personaje_Villano

    {
        [Test]
        public void CrearMagoVillanoConItems()
        {
           
            var mago = new MagoVillano("Voldemort", 5);
            var espada = new Sword("Espada Maldita", 15);
            var escudo = new Shield("Escudo Tenebroso", 10);

            
            mago.AgregarItem(espada);
            mago.AgregarItem(escudo);

            
            Assert.That(mago.Nombre, Is.EqualTo("Voldemort"));
            Assert.That(mago.Vp,Is.EqualTo(5));
            Assert.That(mago.Vida, Is.EqualTo(100));
            Assert.That(mago.AtaqueTotal, Is.GreaterThan(0));
            Assert.That(mago.DefensaTotal, Is.GreaterThan(0));
        }

        [Test]
        public void CrearEnanoVillanoConItemsFisicos()
        {
            // Enano
            var enano = new EnanoVillano("Dunan",5);
            var hacha = new Axe("Hacha de Hierro", 25);
            var escudo = new Shield("Escudo de Hierro", 15);

            // Le agrego los Iteams
            enano.AgregarItem(hacha);
            enano.AgregarItem(escudo);

            // Verifico
            Assert.That(enano.Nombre, Is.EqualTo("Dunan"));
            Assert.That(enano.Vp,Is.EqualTo(5));
            Assert.That(enano.Vida, Is.EqualTo(100));
            Assert.That(enano.AtaqueTotal, Is.EqualTo(25));
            Assert.That(enano.DefensaTotal, Is.EqualTo(15));
        }

        [Test]
        public void CrearElfoVillanoConEspada()
        {
            // Elfo
            var elfo = new ElfoVillano("Arwen",5);
            var espada = new Sword("Espada Élfica", 18);

            // Le agrego iteam
            elfo.AgregarItem(espada);

            // Verifico
            Assert.That(elfo.Nombre, Is.EqualTo("Legolas"));
            Assert.That(elfo.Vp,Is.EqualTo(5));
            Assert.That(elfo.Vida, Is.EqualTo(100));
            Assert.That(elfo.AtaqueTotal, Is.EqualTo(18));
        }
    }
}