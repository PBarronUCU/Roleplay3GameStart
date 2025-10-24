namespace Library.Characters;

public class Encuentros
{
    public PersonajesEnCampo Disponibles;
    public List<IPersonaje> ListaHeroe;

    public Encuentros(PersonajesEnCampo disponibles)
    {
        Disponibles = disponibles;
    }

    public List<IPersonaje> AsignarHeroe()
    { 
        List<IPersonaje> temp1 = new List<IPersonaje>();
        List<PersonajeNoMagicoHeroe> heroe1 = Disponibles.ListaHeroeNoMagico;
        foreach (PersonajeNoMagicoHeroe heroe in heroe1)
        {
            temp1.Add(heroe);
        }
        List<PersonajeMagicoHeroe> heroe2 = Disponibles.ListaHeroeMagico;
        foreach (PersonajeMagicoHeroe hero in heroe2)
        {
            temp1.Add(hero);
        }
        
    }
    
    
}