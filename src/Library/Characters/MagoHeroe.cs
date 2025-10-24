using Library.Items;
namespace Library.Characters;

public class MagoHeroe : PersonajeMagicoHeroe
{
    private Libro _libro;
    public MagoHeroe(string name) : base(name)
    {
        
    }
    public void AgregarLibro(Libro libro)
    {
        _libro = libro;
    }
    
    public void QuitarLibro(Libro libro)
    {
        _libro = null;
    }
}