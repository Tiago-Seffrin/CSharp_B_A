using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exercicios.Classes
{
    class Exercicio19
    {
        public static void Executar()
        {
            //Exercicio simples de instanciar a Classe Pessoa
            Pessoa P1 = new Pessoa();
            Pessoa P2 = new Pessoa();

            Console.WriteLine("Informe o nome da primeira pessoa e a idade:");
            P1.Nome = Console.ReadLine();
            P1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o nome da segunda pessoa e a idade:");
            P2.Nome = Console.ReadLine();
            P2.Idade = int.Parse(Console.ReadLine());

            if (P1.Idade > P2.Idade)
            {
                Console.WriteLine($"{P1.Nome} tem {P1.Idade} anos e portanto é mais valho(a)");
            }
            else
            {
                Console.WriteLine($"{P2.Nome} tem {P1.Idade} anos e portanto é mais velho(a)");
            }
            Console.WriteLine("Fim do primeiro programa e iniciando o segundo");
            // Segundo Exercicio com a mesma Classe

            Console.WriteLine("Informar o nome do primeiro funcionário e o salário:");
            P1.Nome = Console.ReadLine();
            P1.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Informar o nome do segundo funcionário e o salário:");
            P1.Nome = Console.ReadLine();
            P2.Salario = double.Parse(Console.ReadLine());

            double SalarioMedio = (P1.Salario + P2.Salario) / 2;

            Console.WriteLine($"Salário médio dos dois funcionários é {SalarioMedio:f2}");

            Console.ReadLine();
        }
    }
}
