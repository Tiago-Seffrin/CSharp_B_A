using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicios.Fundamentos
{
    class Exercicio16
    {
        public static void Executar()
        {
            double x = 0.0;
            double y = 0.0;
            double z = 0.0;
            double peso1 = 2.0;
            double peso2 = 3.0;
            double peso3 = 5.0;
            double media = 0.0;
            Console.WriteLine("Digite um número inteiro:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Digite {n} valores com uma casa decimal: ");
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                z = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                media = ((x * peso1) + (y * peso2) + (z * peso3)) / (peso1 + peso2 + peso3);
                Console.WriteLine("A média ponderada dos valores é " + media.ToString("f1"), CultureInfo.InvariantCulture );
            }
            

        }
    }
}
