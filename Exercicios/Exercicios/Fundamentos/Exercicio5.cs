using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Fundamentos
{
    class Exercicio5
    {
        public static void Executar()
        {
            int codigo1, codigo2, quantidade1, quantidade2;
            double Valor_Unitario1, Valor_Unitario2, Valor_Pagar; 

            Console.WriteLine("Informar o código da peça 1:");
            codigo1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informar o código da peça 2:");
            codigo2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informar a quantidade que deseja comprar da peça 1:");
            quantidade1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informar a quantidade que deseja comprar da peça 2:");
            quantidade2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Infrome o valor unitário da peça 1:");
            Valor_Unitario1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Infrome o valor unitário da peça 1:");
            Valor_Unitario2 = double.Parse(Console.ReadLine());

            Valor_Pagar = (quantidade1 * Valor_Unitario1) + (quantidade2 * Valor_Unitario2 );
            Console.WriteLine($"O valor total a pagar referente as duas peças e suas respectivas quantidade " +
                $"ficou em $ {Valor_Pagar:f2} reais");
            Console.ReadLine();

        }
    }
}
