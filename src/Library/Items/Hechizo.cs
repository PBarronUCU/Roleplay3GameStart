namespace Library.Items;

public class Hechizo
{
    public string Nombre { get; set; }
    public double Ataque { get; set;  }

    public Hechizo(string nombre, double ataque)
    {
        Nombre = nombre;
        Ataque = ataque;
    }
}