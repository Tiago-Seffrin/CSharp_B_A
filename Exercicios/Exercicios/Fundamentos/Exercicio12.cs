using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Fundamentos
{
    class Exercicio12
    {
        public static void Executar()
        {
            int x = 0;
            int y = 0;

            Console.WriteLine("Digite o valor de duas coordenadas:");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            while (x != 0 && y != 0)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine($"As coordenadas {x} e {y} pertencem ao primeiro quadrante");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine($"As coordenadas {x} e {y} pertencem ao terceiro quadrante");
                }
                else if (x > 0 && y < 0)
                {
                    Console.WriteLine($"As coordenadas {x} e {y} pertencem ao quarto quadrante");
                }
                else
                {
                    Console.WriteLine($"As coordenadas {x} e {y} pertencem ao segundo quadrante");
                }
                Console.WriteLine("Digite o valor de duas coordenadas:");
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());

            }Console.ReadLine();
        }
    }
}
