using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Fundamentos
{
    class Exercicio9
    {
        public static void Executar()
        {
            int n1, n2;

            Console.WriteLine("Digite dois valores inteiros:");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());

            if (n1 % 2 == 0 && n2 % 2 == 0)
            {
                Console.WriteLine("São múltiplos");
            }
            else
            {
                Console.WriteLine("Não são múltiplos");
            }
            Console.ReadLine();

        }
    }
}
