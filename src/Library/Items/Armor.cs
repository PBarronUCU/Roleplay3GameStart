namespace Library.Items;

public class Armor : IIDefensaNoMag
{
    public string Nombre { get; set; }
    public double ValorDefensa { get; set;  }

    public Armor(string nombre, double defensa)
    {
        Nombre = nombre;
        ValorDefensa = defensa;
    }
}