namespace Library.Items;

public class Sword : IIAtaqueNoMag
{
    public string Nombre { get; set; }
    public double ValorAtaque { get; set;  }

    public Sword (string nombre, double ataque)
    {
        Nombre = nombre;
        ValorAtaque = ataque;
    }
}