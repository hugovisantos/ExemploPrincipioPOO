using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploPrincipioPOO
{
    public class Leao : Mamiferos, IFelino
    {
        public override void Amamentar()
        {
            Console.WriteLine("Amamentando...");
        }

        public void Rugir()
        {
            Console.WriteLine("Rugindo...");
        }

        public override string ToString()
        {
            var texto = $"Tipo:{nameof(Leao)}\n";
            texto += base.ToString();

            return texto;
        }
    }
}
