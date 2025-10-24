using Library.Items;
namespace Library.Characters;

public class MagoVillano : PersonajeNoMagicoVillano
{
    private Libro _libro;
    
    public MagoVillano(string name,int vp) : base(name,vp)
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

