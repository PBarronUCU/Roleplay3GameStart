namespace Library.Characters;

public class PersonajesEnCampo
{
    public List<PersonajeMagicoHeroe> ListaHeroeMagico = new List<PersonajeMagicoHeroe>();
    public List<PersonajeNoMagicoHeroe> ListaHeroeNoMagico = new List<PersonajeNoMagicoHeroe>();
    public List<PersonajeMagicoVillano> ListaVillanoMagico = new List<PersonajeMagicoVillano>();
    public List<PersonajeNoMagicoVillano> ListaVillanoNoMagico = new List<PersonajeNoMagicoVillano>();

    public PersonajesEnCampo()
    {
        
    }

    public void AddHeroeMagico(PersonajeMagicoHeroe p)
    {
        ListaHeroeMagico.Add(p);
    }

    public void AddHeroeNoMagico(PersonajeNoMagicoHeroe p)
    {
        ListaHeroeNoMagico.Add(p);
    }

    public void AddVillanoMagico(PersonajeMagicoVillano p)
    {
        ListaVillanoMagico.Add(p);
    }

    public void AddVillanoNoMagico(PersonajeNoMagicoVillano p)
    {
        ListaVillanoNoMagico.Add(p);
    }
}
