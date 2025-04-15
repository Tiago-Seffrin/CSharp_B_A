using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Fundamentos
{
    class Exercicio18
    {
        public static void Executar()
        {
            Console.WriteLine("Digite um número positivo");
            double num = double.Parse(Console.ReadLine());

            int fat = 1;

            for (int i = 1; i <= num; i++)
            {
                fat = fat * i;
            }
            Console.WriteLine(fat);

            Console.ReadLine();
        }
    }
}
