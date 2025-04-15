using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Fundamentos
{
    class Exercicio7
    {
        public static void Executar()
        {
            int n1;

            Console.WriteLine("Digite un número inteiro positivo ou negativo");
            n1 = int.Parse(Console.ReadLine());

            if (n1 >= 0)
            {
                Console.WriteLine($"O número {n1} é positivo. ");
            }
            else
            {
                Console.WriteLine($"O número {n1} é negativo");
            }
            Console.ReadLine();
        }
    }
}
