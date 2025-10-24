namespace Library.Items;

public class Libro
{
    public string Nombre { get; set; }
    private List<Hechizo> hechizos;

    public Libro(string nombre)
    {
        Nombre = nombre;
        hechizos = new List<Hechizo>();
    }
    public void Agregar(Hechizo hechizo)
    {
        hechizos.Add(hechizo);
        
    }

    public void Quitar(Hechizo hechizo)
    {
        hechizos.Remove(hechizo);
    }
}