using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeEstoquesPOO
{
    class Ebook : Produto, IEstoque
    {
        public string autor;
        private int vendas;

        public Ebook(string nome, float preco, string autor)
        {
            this.nome = nome;
            this.preco = preco;
            this.autor = autor;
        }

        public void Exibir()
        {
            Console.WriteLine($"" +
                $"Nome: {nome}\n" +
                $"Preço: {preco}\n" +
                $"Vendas: {vendas}\n" +
                $"Autor: {autor}");
            Console.WriteLine("================================");
        }
    }

    public void RegistrarEntrada()
    {
    }

    public void RegistrarSaida()
    {
    }
}
}
