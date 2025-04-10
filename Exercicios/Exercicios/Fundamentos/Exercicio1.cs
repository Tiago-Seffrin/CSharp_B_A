using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Fundamentos
{
    class Exercicio1
    {
        public static void Executar()
        {
            int valor1, valor2;
            double soma;

            Console.WriteLine("Digite dois valores. Os valores devem ser dois números inteiros.");
            valor1 = int.Parse(Console.ReadLine());
            valor2 = int.Parse(Console.ReadLine());

            soma = valor1 + valor2;

            Console.WriteLine($"A soma do valor 1: {valor1} com o valor 2: {valor2} é igual a {soma}");
            Console.ReadLine();

        }
    }
}
