namespace Library.Items;

public class MagicSword : IIAtaqueMag
{
    public string Nombre { get; set; }
    public double ValorAtaque { get; set;  }

    public MagicSword(string nombre, double ataque)
    {
        Nombre = nombre;
        ValorAtaque = ataque;
    }
}