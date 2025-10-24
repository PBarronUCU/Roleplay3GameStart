using Library.Items;

namespace Library.Characters
{
    public class Elfo : IPersonaje
    {
        public string Nombre { get; set; }
        public double Vida { get; set; } = 100;

        private List<IItemNoMag> _listaitems = new List<IItemNoMag>();

        public Elfo(string name)
        {
            this.Nombre = name;
        }

        public double AtaqueTotal
        {
            get
            {
                double resultado = 0;
                foreach (var item in _listaitems)
                {
                    if (item is IIAtaqueNoMag)
                    {
                        resultado += item.ValorAtaque;
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
                    if (item is IIDefensaNoMag)
                    {
                        resultado += item.ValorDefensa;
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
    }
}
