namespace Library.Items;

public class Helmet : IIDefensaNoMag
{
    public string Nombre { get; set; }
    public double ValorDefensa { get; set;  }

    public Helmet(string nombre, double defensa)
    {
        Nombre = nombre;
        ValorDefensa = defensa;
    }
}