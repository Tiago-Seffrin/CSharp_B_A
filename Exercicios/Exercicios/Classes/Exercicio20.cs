using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Classes
{
    class Exercicio20
    {
        public static void Executar()
        {
            Produto Prod = new Produto();

            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome:");
            Prod.Nome = Console.ReadLine();
            Console.Write("Preço:");
            Prod.Preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade no estoque: ");
            Prod.Quantidade = int.Parse(Console.ReadLine());

            Prod.DadosAtualizados();
            Console.WriteLine();

            Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque:");
            int Qtde = int.Parse(Console.ReadLine());
            Prod.AdicionarProdutos(Qtde);
            Prod.DadosAtualizados();
            
            Console.WriteLine("Digite o número de produtos a ser removido do estoque:");
            Qtde = int.Parse(Console.ReadLine());
            Prod.RemoverProdutos(Qtde);
            Prod.DadosAtualizados();

            Console.ReadLine();
        }
    }
}
