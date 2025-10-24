namespace Library.Items;

public class Shield : IIDefensaNoMag
{
    public string Nombre { get; set; }
    public double ValorDefensa { get; set;  }

    public Shield(string nombre, double defensa)
    {
        Nombre = nombre;
        ValorDefensa = defensa;
    }
}