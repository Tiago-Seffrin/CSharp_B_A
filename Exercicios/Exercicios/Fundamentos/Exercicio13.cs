using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Fundamentos
{
    class Exercicio13
    {
        public static void Executar()
        {
            int nota;

            Console.WriteLine("Dentre os produtos oferecidos por esse estabelecimento qual deles atende melhor" +
                " as suas necessidades ? Digite 1 para Álcool, 2 para Gasolina, 3 para Diesel e 4 para encerrar" +
                " esta pesquisa.");
            nota = int.Parse(Console.ReadLine());

            while (nota != 4 && nota <= 4 && nota > 0)
            {
                if (nota == 1)
                {
                    Console.Write($"Sua escolha foi {nota} - ");
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("Álcool");
                    Console.ResetColor();
                    Console.WriteLine(". Obrigado por sua colaboração.");
                }
                else if (nota == 2)
                {
                    Console.Write($"A sua escolha foi {nota} - ");
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("Gasolina");
                    Console.ResetColor();
                    Console.WriteLine(". Obrigado por sua colaboração.");
                }
                else
                {
                    Console.WriteLine($"A sua escolha foi {nota} - ");
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("Diesel");
                    Console.ResetColor();
                    Console.Write(". Obrigado por sua colaboração.");
                }
                
                Console.WriteLine("Deseja informar outro produto? Digite novamente número de 1 a 3 para" +
                    " escolhe o produto ou 4 para finalizar o programa.");
                nota = int.Parse(Console.ReadLine());
               
            }
            if (nota == 4)
            {
                Console.WriteLine("Fim do programa. Obrigado!");
            }           
            else
            {
                Console.WriteLine("Opção inválida! Fim do programa");
            }
        }
    }
}
