namespace Library.Items;

public class Staff : IIAtaqueMag, IIDefensaMag
{
    public string Nombre { get; set; }
    public double ValorAtaque { get; set;  }
    public double ValorDefensa { get; set; }

    public Staff(string nombre, double ataque,double defensa)
    {
        Nombre = nombre;
        ValorAtaque = ataque;
        ValorDefensa = defensa;
    }
}