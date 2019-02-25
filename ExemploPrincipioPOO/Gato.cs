using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploPrincipioPOO
{
    public class Gato : Mamiferos, IAquatico
    {
        public static void Miar()
        {
            Console.WriteLine("Miar...");
        }

        public override void Amamentar()
        {
            Console.WriteLine("Amamentando...");
            
            var mensagem = $"O gato mama";
            Console.WriteLine(mensagem);
        }


        public void Nadar()
        {
            Console.WriteLine("Nadando...");
        }


    }
}
