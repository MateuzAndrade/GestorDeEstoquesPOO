﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeEstoquesPOO
{
    class Curso : Produto
    {
        public string autor;
        private int vagas;

        public Curso(string nome, float preco, string autor, int vagas)
        {
            this.nome = nome;
            this.preco = preco;
            this.autor = autor;
        }
    }
}
