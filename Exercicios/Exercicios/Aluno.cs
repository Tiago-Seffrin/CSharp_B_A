using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class Aluno
    {
        public string Nome;
        

        public void NotaFinal(double nota1, double nota2, double nota3)
        {

            double MediaFinal = nota1 + nota2 + nota3;

            if(MediaFinal >= 60.00)
            {
               Console.WriteLine($"Média final do aluno(a) {Nome} foi {MediaFinal:f2}. Aprovado!");
            }
            else
            {
                Console.WriteLine($"Média final do aluno(a) {Nome} foi {MediaFinal:f2}. Reprovado");
                double Faltou = 60 - MediaFinal;
                Console.WriteLine($"Faltaram {Faltou} pontos");
            }
            
        }
       
    }
}
