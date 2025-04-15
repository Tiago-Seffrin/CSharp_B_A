using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Fundamentos
{
    class Exercicio14
    {
        public static void Executar()
        {
            //Estrutura FOR

            int x = 0;
            int Impar = 0;

            Console.WriteLine("Digite um número:");
            x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= x; i++)
            {
                Impar = i % 2;
                if (Impar != 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
