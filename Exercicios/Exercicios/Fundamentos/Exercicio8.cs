using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Fundamentos
{
    class Exercicio8
    {
        public static void Executar()
        {
            int n1;
            
            Console.WriteLine("Digite um número inteiro positivo ou negativo");
            n1 = int.Parse(Console.ReadLine());
            
            if (n1 % 2 == 0)
            {
                Console.WriteLine($"O número {n1} é par");
            }
            else
            {
                Console.WriteLine($"o número {n1} é ímpar");
            }
            Console.ReadLine();
        }
    }
}
