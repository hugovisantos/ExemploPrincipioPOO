using ExemploPrincipioPOO.Enums;
using System;

namespace ExemploPrincipioPOO
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gatos");
            Gato gato = new Gato(); //Pascal Case 
            //gato.Miar(); 
            Gato.Miar();
            gato.Amamentar();
            IAquatico gatoAquatico = new Gato();

            Mamiferos mamiferosLeao = new Leao();
            mamiferosLeao.Amamentar();
            mamiferosLeao.Locomover();


            Console.WriteLine("Leoes");
            Leao leao = new Leao();
            leao.Amamentar();
            leao.Rugir();
            leao.Locomover();
            leao.GlandulasMamarias = GlandulasMamariasEnum.MAIS_DE_DUAS_GLANDULAS_MAMARIAS;
            leao.Patas = PatasEnum.QUATRO_PATAS;
            
            Console.WriteLine(leao.ToString());


            Console.WriteLine("Baleias");
            var baleia = new Baleia();
            baleia.Locomover();

            Console.WriteLine(PelugemEnum.CUMPRIDA);
            Console.WriteLine(PelugemEnum.RALA);
            Console.WriteLine(PelugemEnum.SEM);

            Console.WriteLine(leao.ToString());
                       
            Console.ReadKey();
        }

        
        
    }
}
