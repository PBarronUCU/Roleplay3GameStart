using Library.Items;

namespace Library.Characters;

public class Mago : IPersonajeMagico
{
    public string Nombre {get; set;}
    public double Vida { get; set; } = 100;
    private List<IItemNoMag> _listaitems = new List<IItemNoMag>();
    private List<IItemMag> _listaitemsmag = new List<IItemMag>();
    public Mago(string name)
    {
        this.Nombre = name;
    }

    private Libro _libro;

    public double AtaqueTotal
    {
        get
        {
            double resultado = 0;
            foreach (var item in _listaitems)
            {
                if (item is IIAtaqueNoMag ataque)
                {   
                    
                    resultado += ataque.ValorAtaque;
                }
            }

            foreach (var itemMagico in _listaitemsmag)
            {
                if (itemMagico is IIAtaqueMag ataqueMag)
                {
                    resultado += ataqueMag.ValorAtaque;
                }
            }
            
            return resultado;
        }
    }

    public double DefensaTotal
    {
        get
        {
            double resultado = 0;
            foreach (var item in _listaitems)
            {
                if (item is IIDefensaNoMag defensa)
                {
                    resultado += defensa.ValorDefensa;
                }
            }

            foreach (var itemMagico in _listaitemsmag)
            {
                if (itemMagico is IIDefensaMag  defensaMag)
                {
                    resultado += defensaMag.ValorDefensa;
                }
            }
            
            return resultado;
        }
    }

    public void Atacar(IPersonaje personaje)
    {
        double danio = this.AtaqueTotal;
        double defensa = personaje.DefensaTotal;
        double danio_resultante = 0;
        if (defensa > danio)
        {
            danio_resultante = 0;
        }
        else
        {
            danio_resultante = danio - defensa; 
        }
        if (danio_resultante >= personaje.Vida)
        {
            personaje.Vida = 0;
        }
        else
        {
            personaje.Vida -= danio_resultante;
        }
    }

    public void Curar(IPersonaje personaje)
    {
        personaje.Vida = 100;
    }

    public void AgregarItem(IItemNoMag item)
    {
        _listaitems.Add(item);
    }

    public void QuitarItem(IItemNoMag item)
    {
        _listaitems.Remove(item);
    }
    
    public void AgregarItemMag(IItemMag item)
    {
        _listaitemsmag.Add(item);
    }
    
    public void QuitarItemMag(IItemMag item)
    {
        _listaitemsmag.Remove(item);
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