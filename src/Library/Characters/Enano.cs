using Library.Items;

namespace Library.Characters;

public class Enano : IPersonaje //Se indica que la clase Enano implementa la interfaz IPersonaje.
{
    public string Nombre {get; set;} //El nombre.
    public double Vida { get; set; } = 100; //Los puntos de vida.
    private List<IItemNoMag> _listaitems = new List<IItemNoMag>(); //La lista de items que tiene.
    
    public Enano(string name, double vida) //El constructor del nombre y la vida.
    {
        this.Nombre = name;
        Vida = vida;
    }
    public double AtaqueTotal //Se define el ataque total que puede hacer.
        {
            get
            {
                double resultado = 0; //Inicialmente el resultado es 0.
                foreach (var item in _listaitems)
                {
                    if (item is IIAtaqueNoMag) //Para cada item que tiene en la lista...
                    {
                        resultado += item.ValorAtaque; //... le suma su valor al resultado.
                    }
                }
                
                return resultado; //Retorna el valor final que tenga en resultado.
            }
        }
    
    public double DefensaTotal //Se define la defensa total que puede hacer.
    {
        get
        {
            double resultado = 0; //Inicialmente el resultado es 0.
            foreach (var item in _listaitems)
            { 
                if (item is IIDefensaNoMag) //Para cada item que tiene en la lista...
                { 
                    resultado += item.ValorDefensa; //... le suma su valor al resultado.
                }
            }
            return resultado; //Retorna el valor final que tenga en resultado.
        } 
    }
    
    public void Atacar(IPersonaje personaje)
    {
        double danio = this.AtaqueTotal; //Se carga el valor
        double defensa = personaje.DefensaTotal;
        double danio_resultante = 0;
        
        if (defensa > danio)
        {
            danio_resultante = 0; //Si la defensa de el personaje al que atacó es menor al ataque que le hace, el daño resultante será 0.
        } else
        { 
            danio_resultante = danio - defensa; //Sinó, al daño que le hizo al otro personaje se le resta la defensa del personaje que recibió el ataque.
        } if (danio_resultante >= personaje.Vida)
        { 
            personaje.Vida = 0; //Mientras que si el daño resultante es mayor o igual a la vida del personaje atacado, se retorna 0.
        } else
        {
            personaje.Vida -= danio_resultante; //O sinó, simplemente se le resta a la vida el daño resultante.
        }
    }
     
    public void Curar(IPersonaje personaje)
    { 
        personaje.Vida = 100; //Cuando el enano se va a cucrar, el valor de su vida cambia a valer 100, si es que este es menor a 100.
    }
    public void AgregarItem(IItemNoMag item)
    {
        _listaitems.Add(item); //Se agrega un item a la lista de items que tiene.
    }
    
    public void QuitarItem(IItemNoMag item)
    {
        _listaitems.Remove(item); //Se quita un item a la lista de items que tiene.
    }
}