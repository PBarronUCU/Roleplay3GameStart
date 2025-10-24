namespace Library.Characters;

public class Encuentros
{
    public PersonajesEnCampo Disponibles;
    public List<IPersonaje> ListaHeroe;
    public List<IPersonaje> ListaVillano;

    public Encuentros(PersonajesEnCampo disponibles)
    {
        Disponibles = disponibles;
        ListaHeroe = AsignarHeroe();
        ListaVillano = AsignarVillano();
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
        return temp1;
    }
    
    public List<IPersonaje> AsignarVillano()
    { 
        List<IPersonaje> temp1 = new List<IPersonaje>();
        List<PersonajeNoMagicoVillano> villano1 = Disponibles.ListaVillanoNoMagico;
        foreach (PersonajeNoMagicoVillano villano in villano1)
        {
            temp1.Add(villano);
        }
        List<PersonajeMagicoVillano> villano2 = Disponibles.ListaVillanoMagico;
        foreach (PersonajeMagicoVillano villano in villano2)
        {
            temp1.Add(villano);
        }
        return temp1;
    }

    public void DoEncounter()
    {
        int i = 0;
        int z = 0;
        int heroMax = ListaHeroe.Count;
        bool heroesvivos = true;
        bool villanosvivos = false; // Inicia asuminedo que los villans estan muertos
        while (heroesvivos&!villanosvivos)
        {
            if (!villanosvivos)
            {
                foreach (IPersonaje villano in ListaVillano)
                {
                    if (villano.Vida != 0)
                    {
                        bool ataco = false;
                        int recorrido = -1;
                        while (!ataco & heroesvivos)
                        {
                            if (i < heroMax)
                            {
                                ;
                            }
                            else
                            {
                                i = 0;
                            }

                            if (ListaHeroe[i].Vida > 0)
                            {
                                villano.Atacar(ListaHeroe[i]);
                                ataco = true;
                            }

                            i++;
                            if (recorrido == heroMax)
                            {
                                heroesvivos = false;
                            }
                        }
                    }
                    

                }
            }

            if (heroesvivos)
            {
                foreach (IPersonaje heroe in ListaHeroe)
                {
                    
                    villanosvivos = false;
                    foreach (IPersonaje villano in ListaVillano)
                    {
                        
                        if (villano.Vida == 0)
                        {
                            ;
                        }
                        else
                        {
                            villanosvivos = true;
                            heroe.Atacar(villano);
                            if (villano.Vida == 0)
                            {
                                villanosvivos = false;
                            }
                        }
                    }
                }
            }




        }
    }
    
    
    
}