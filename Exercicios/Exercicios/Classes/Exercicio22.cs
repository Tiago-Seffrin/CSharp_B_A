using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Classes
{
    class Exercicio22
    {
        public static void Executar()
        {
            Funcionario func = new Funcionario();

            Console.Write("Informe o nome do funcionário: ");
            func.Nome = Console.ReadLine();
            
            Console.Write($"Informe o salário bruto do Sr(a).{func.Nome}: ");
            func.SalarioBruto = double.Parse(Console.ReadLine());

            Console.Write("Informe o valor a ser descontado de impostos: ");
            func.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine(func);

            Console.Write("Informe a porcentagem que o salário deve ser aumentado: ");
            double aumento = double.Parse(Console.ReadLine());
            func.AumentarSalario(aumento);

            Console.WriteLine(func);

            Console.ReadLine();
        }
    }
}
