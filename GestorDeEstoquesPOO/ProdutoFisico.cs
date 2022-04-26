using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeEstoquesPOO
{
    internal class ProdutoFisico : Produto, IEstoque
    {
        public float frete;
        private int estoque;

        public ProdutoFisico(string nome, float preco, float frete)
        {
            this.nome = nome;
            this.preco = preco;
            this.frete = frete;
        }

        public void Exibir()
        {
            Console.WriteLine($"" +
                $"Nome: {nome}\n" +
                $"Preço: {preco}\n" +
                $"Estoque: {estoque}");
            Console.WriteLine("================================");
        }

        public void RegistrarEntrada()
        {
        }

        public void RegistrarSaida()
        {
        }
    }
}
