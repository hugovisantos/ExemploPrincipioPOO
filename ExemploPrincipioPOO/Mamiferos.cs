using ExemploPrincipioPOO.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploPrincipioPOO
{
    public abstract class Mamiferos
    {
        public PelugemEnum Pelugem { get; set; }
        public PatasEnum Patas { get; set; }
        public GlandulasMamariasEnum GlandulasMamarias { get; set; }
        public abstract void Amamentar();
        public virtual void Locomover()
        {
            AndarSobreQuatroPatas();
        }

        private void AndarSobreQuatroPatas()
        {
            Console.WriteLine("Andar sobre quatro patas");
        }

        public override string ToString()
        {
            var texto = $"Pelugem:{this.Pelugem}\n" +
                        $"Patas: {this.Patas}\n" +
                        $"Glandulas:{this.GlandulasMamarias}\n";
            return texto;
        }

    }
}
