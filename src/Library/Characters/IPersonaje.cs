using Library.Items;

namespace Library.Characters
{
    public interface IPersonaje
    {
        // Properties
        string Nombre { get; set; }
        double Vida { get; set; }
        double AtaqueTotal { get; }
        double DefensaTotal { get; }

        // Methods
        void Atacar(IPersonaje personaje);
        void Curar(IPersonaje personaje);
        void AgregarItem(IItemNoMag item);
        void QuitarItem(IItemNoMag item);
    }
}