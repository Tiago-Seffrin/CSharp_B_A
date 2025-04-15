using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Fundamentos
{
    class Exercicio17
    {
        public static void Executar()
        {

            Console.WriteLine("Informe o valor de vezes que deseja executar o programa");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Informe dois valores separados por espaço:");
                string[] Vetor = Console.ReadLine().Split(' ');
                double a = double.Parse(Vetor[0]);
                double b = double.Parse(Vetor[1]);

                if (b == 0)
                {
                    Console.WriteLine("Divisão impossível");
                }
                else
                {
                    double div = a / b;
                    Console.WriteLine($"Resultado da divisão entre a / b: {div}");
                }

            }
            Console.WriteLine("Fim da execução do programa");
            Console.ReadLine();
            

        }
    }
}
