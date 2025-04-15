using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Fundamentos
{
    class Exercicio10
    {
        public static void Executar()
        {
            double HoraInicial, HoraFinal, HoraMaxima;
            HoraMaxima = 24.00;
            double Resultado = 0.0;

            Console.WriteLine("Digite a hora inicar da partida:");
            HoraInicial = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a hora do término da partida:");
            HoraFinal = double.Parse(Console.ReadLine());

            if (HoraInicial > 12 && HoraFinal < 12)
            {
                Resultado = 24 +  HoraFinal - HoraInicial;
                Console.WriteLine($"O tempo de partida foi de {Resultado} horas");
            }
            else if(HoraInicial == 0.0 && HoraFinal == 0.0 || HoraInicial == 24.0 && HoraFinal == 24.0)
            {
                Console.WriteLine("A partida teve duração de 24 horas");
            }
            else
            {
                Resultado = HoraFinal - HoraInicial;
                Console.WriteLine($"A partida teve a duração de {Resultado} horas");
            }    

            Console.ReadLine();
        }        
    }
}
