using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exercicios
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEstoque()
        {
            return Preco * Quantidade;
            
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade = Quantidade + quantidade;
        }
        public  void RemoverProdutos(int quantidade)
        {
            Quantidade = Quantidade - quantidade;
        }
        public void DadosAtualizados()
        {
            Console.WriteLine($"Dados do produto: {Nome}, {Preco:f2}, {Quantidade} unidades, Total: ${ValorTotalEstoque():f2}");
        }

    }
}
