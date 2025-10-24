
using NUnit.Framework;
using Library.Characters;
using Library.Items;

namespace TestLibrary
{
    [TestFixture]
    public class Creacion_Personaje_Heroe

    {
        [Test]
        public void CrearMagoHeroeConItemsMagicos()
        {
            // Mago
            var mago = new MagoHeroe("Merlín");
            var staff = new Staff("Bastón de Poder", 20, 10);
            var capa = new Cape("Capa de Invisibilidad", 15);
            var libro = new Libro("Libro de Hechizos");

            //Agrego Iteams al mago
            mago.AgregarItemMag(staff);
            mago.AgregarItemMag(capa);
            mago.AgregarLibro(libro);

            // Verifico
            Assert.That(mago.Nombre, Is.EqualTo("Merlín"));
            Assert.That(mago.Vida, Is.EqualTo(100));
            Assert.That(mago.AtaqueTotal, Is.GreaterThan(0));
            Assert.That(mago.DefensaTotal, Is.GreaterThan(0));
        }

        [Test]
        public void CrearEnanoHeroeConItemsFisicos()
        {
            // Enano
            var enano = new EnanoHeroe("Gimli");
            var hacha = new Axe("Hacha Doble", 25);
            var escudo = new Shield("Escudo de Hierro", 15);

            // Le agrego los Iteams
            enano.AgregarItem(hacha);
            enano.AgregarItem(escudo);

            // Verifico
            Assert.That(enano.Nombre, Is.EqualTo("Gimli"));
            Assert.That(enano.Vida, Is.EqualTo(100));
            Assert.That(enano.AtaqueTotal, Is.EqualTo(25));
            Assert.That(enano.DefensaTotal, Is.EqualTo(15));
        }

        [Test]
        public void CrearElfoHeroeConEspada()
        {
            // Elfo
            var elfo = new ElfoHeroe("Legolas");
            var espada = new Sword("Espada Élfica", 18);

            // Le agrego iteam
            elfo.AgregarItem(espada);

            // Verifico
            Assert.That(elfo.Nombre, Is.EqualTo("Legolas"));
            Assert.That(elfo.Vida, Is.EqualTo(100));
            Assert.That(elfo.AtaqueTotal, Is.EqualTo(18));
        }
    }
}