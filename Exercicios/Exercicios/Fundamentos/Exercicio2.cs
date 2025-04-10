using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Fundamentos
{
    class Exercicio2
    {
        public static void Executar()
        {
            double raio;
            double area;
            double TT = 3.14159;
            
            Console.WriteLine("Digite o valor do raio: ");
            raio = double.Parse(Console.ReadLine());

            Console.WriteLine("Fórmula usada será area = TT . raio2");

            area = TT * Math.Pow(raio, 2);
            Console.WriteLine($"Valor do raio: {raio}. Valor da área: {area:f4}");
            Console.ReadLine();

        }
    }
}
