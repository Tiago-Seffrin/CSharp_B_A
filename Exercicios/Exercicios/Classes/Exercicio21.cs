using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Classes
{
    class Exercicio21
    {
        public static void Executar()
        {
            Retangulo retangulo = new Retangulo();

            Console.WriteLine("Informe a largura e a altura do retângulo:");
            retangulo.Largura = double.Parse(Console.ReadLine());
            retangulo.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine(retangulo);
            Console.ReadLine();


        }
    }
}
