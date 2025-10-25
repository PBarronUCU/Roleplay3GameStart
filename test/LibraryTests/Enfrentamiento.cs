using NUnit.Framework;

using Library.Characters;
using Library.Items;
namespace TestLibrary;

public class Enfrentamiento
{
    [Test]
    public void HeroeSeCuraYGanaXPAlMatarVillano()
    {
        var heroe = new MagoHeroe("Gandalf");
        var villano = new MagoVillano("Saruman", 20);

        var staff = new Staff("Bastón", 200, 0); // Ataque alto
        heroe.AgregarItemMag(staff);

        heroe.Vida = 40;
        int xpInicial = heroe.Xp;

        heroe.Atacar(villano);

        Assert.That(villano.Vida, Is.EqualTo(0));
        Assert.That(heroe.Vida, Is.EqualTo(100));
        Assert.That(heroe.Xp, Is.EqualTo(xpInicial + 5));
    }

}