namespace Library.Items;

public class Cape : IIDefensaMag
{
    public string Nombre { get; set; }
    public double ValorDefensa { get; set;  }

    public Cape(string nombre, double defensa)
    {
        Nombre = nombre;
        ValorDefensa = defensa;
    }
}