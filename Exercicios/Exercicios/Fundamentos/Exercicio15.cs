using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Fundamentos
{
    class Exercicio15
    {
        public static void Executar()
        {
            int n = 0;
            int cont_in = 0;
            int cont_out = 0;

            Console.WriteLine("Digite o valor de vezes para repetir: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Digite o valor a ser testado:");
                int x = int.Parse(Console.ReadLine());

                if (x >= 10 && x <= 20)
                {
                    cont_in = cont_in + 1;
                }
                else
                {
                    cont_out = cont_out + 1;
                }
                
            }
            Console.WriteLine(cont_in + " in");
            Console.WriteLine(cont_out + " out");
            Console.ReadLine();
        }
    }
}
