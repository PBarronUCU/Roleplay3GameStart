namespace Library.Items;

public class Axe : IIAtaqueNoMag
{
    public string Nombre { get; set; }
    public double ValorAtaque { get; set;  }

    public Axe(string nombre, double ataque)
    {
        Nombre = nombre;
        ValorAtaque = ataque;
    }
}