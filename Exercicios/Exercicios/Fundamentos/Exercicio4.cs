using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Fundamentos
{
    class Exercicio4
    {
        public static void Executar()
        {
            int matricula;
            double horasT, valorH, salary;


            Console.WriteLine("Informe a matrícula do funcionário: ");
            matricula = int.Parse(Console.ReadLine());

            Console.WriteLine("Informar o número de horas trabalhadas do funionário:");
            horasT = double.Parse(Console.ReadLine());

            Console.WriteLine("Informar o valor da hora trabalhada do funcionário com vírgula para separação" +
                " de número fracionário:");
            valorH = double.Parse(Console.ReadLine());

            salary = horasT * valorH;

            Console.WriteLine($"O funcionário de matrícula {matricula}, trabalhou {horasT} horas a um valor de " +
                $"$ {valorH:f2} reais por hora. Seu pagamento é de ${salary:f2} reais");
            Console.ReadLine();
        }
    }
}
