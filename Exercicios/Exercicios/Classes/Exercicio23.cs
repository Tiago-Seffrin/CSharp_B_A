using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Classes
{
    class Exercicio23
    {
        public static void Executar()
        {
            Aluno aluno = new Aluno();

            Console.WriteLine("Informe o nome e as 3 notas dos trimestres do aluno: ");
            aluno.Nome = Console.ReadLine();
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            double n3 = double.Parse(Console.ReadLine());

            aluno.NotaFinal(n1,n2,n3);


            Console.ReadLine();
        }
    }
}
