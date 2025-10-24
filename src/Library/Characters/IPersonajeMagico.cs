using Library.Items;

namespace Library.Characters
{
    public interface IPersonajeMagico : IPersonaje
    {
        // Properties
        string Nombre { get; set; }
        double Vida { get; set; }
        double AtaqueTotal { get; }
        double DefensaTotal { get; }
        // Methods
        void AgregarItemMag(IItemMag item);
        void QuitarItemMag(IItemMag item);
        void AgregarLibro(Libro libro);
        void QuitarLibro(Libro libro);
    }
}