using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Fundamentos
{
    class Exercicio3
    {
        public static void Executar()
        {
            int a, b, c, d, diferenca;
            
            Console.WriteLine("Digite 4 valores inteiros:");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());

            diferenca = (a * b - c * d);

            Console.WriteLine($"Diferença: {diferenca}");
            Console.ReadLine();
        }
    }
}
