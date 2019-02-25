using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploPrincipioPOO
{
    public class Baleia : Mamiferos, IAquatico
    {
        public override void Amamentar()
        {
            Console.WriteLine("Amamentando...");
        }

        public void Nadar()
        {
            Console.WriteLine("Nadando...");
        }

        public override void Locomover()
        {
            this.Nadar();
        }
    }
}
