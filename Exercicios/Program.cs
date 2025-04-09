using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {

            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            int idade = 30;
            int codigo = 5290;
            string genero = "M";

            double preco1 = 2100.00;
            double preco2 = 650.50;
            double medida = 53.234567;

            //Imprimir na tela conforme o solicitado

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo o preço é ${preco1:f2}");
            Console.WriteLine($"{produto2}, cujo o preço é ${preco2:f2}");
            
            Console.WriteLine();
            Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero: {genero}");
            Console.WriteLine();
            //Medidas com 8 casas decimais
            Console.WriteLine($"Medida: {medida:f8}");
            //Medida com 3 casa decimais
            Console.WriteLine($"Medida: {medida:f3}");
            //Medida com ponto no lugar de vírgula
            Console.WriteLine("Medida: " + medida.ToString("f3", CultureInfo.InvariantCulture));
            Console.ReadLine();


        }
    }
}
