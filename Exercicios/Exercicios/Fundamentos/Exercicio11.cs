using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Fundamentos
{
    class Exercicio11
    {
        public static void Executar()
        {
            //While - programa de senhas - senha correta 2002
            int Password = 2002;
            string mensagem = "Acesso Permitido";

            Console.Write("Digite uma senha uma senha: ");
            int Senha = int.Parse(Console.ReadLine());

            while (Senha != Password)
            {
                Console.WriteLine("Senha inválida!");

                Console.Write("Digite uma senha (a senha: ");
                Senha = int.Parse(Console.ReadLine());
                            
            }
            Console.ForegroundColor = ConsoleColor.White; //deixar a letra vermelha
            Console.BackgroundColor = ConsoleColor.Green; //deixar o fundo da escrita verde

            Console.WriteLine(mensagem);

            Console.ResetColor(); // resetar as cores ao padrão
            Console.ReadLine();
        }
    }
}
