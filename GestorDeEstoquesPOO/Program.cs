using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeEstoquesPOO
{
    class Program
    {

        static List<IEstoque> produtos = new List<IEstoque>();
        enum Menu
        {
            Listar = 1,
            Adicionar,
            Remover,
            RegistarEntrada,
            RegistarSaida,
            Sair

        }

        enum MenuCadastroProduto
        {
            Produtofisico = 1,
            Ebook,
            Curso

        }
        static void Main(string[] args)
        {
            bool escolheuSair = false;

            while (!escolheuSair) /* Loop para o menu , com ! "enquanto"*/
            {
                Console.WriteLine("==============================");
                Console.WriteLine("Sistema de Gestão de Estoques");
                Console.WriteLine("==============================");

                Console.WriteLine(
                    "1 - Listar\n" +
                    "2 - Adicionar\n" +
                    "3 - Remover\n" +
                    "4 - Registrar Entrada\n" +
                    "5 - Registar Saída\n" +
                    "6 - Sair\n"
                    );

                string opStr = Console.ReadLine();
                int opInt = int.Parse(opStr); /*Casting para conversão dos dados */
                Menu escolha = (Menu)opInt;

                if (opInt > 0 && opInt < 7)
                {

                    switch (escolha)
                    {
                        case Menu.Listar:
                            break;
                        case Menu.Adicionar:
                            Cadastro();
                            break;
                        case Menu.Remover:
                            break;
                        case Menu.RegistarEntrada:
                            break;
                        case Menu.RegistarSaida:
                            break;
                        case Menu.Sair:
                            escolheuSair = true;
                            break;
                        default:
                            break;
                    }

                }
                else
                {
                    escolheuSair = true;
                }
                Console.Clear();
            }
            Console.Clear();
        }

        static void Cadastro()
        {
            Console.WriteLine("==============================");
            Console.WriteLine("Cadstro de Produtos");
            Console.WriteLine("==============================");

            Console.WriteLine(
                "1 - Produto Físico\n" +
                "2 - Ebook\n" +
                "3 - Curso\n"
                );

            string OpStr = Console.ReadLine();
            int Opselec = int.Parse(OpStr);
            MenuCadastroProduto Escolha = (MenuCadastroProduto)Opselec;

            switch (Escolha)
            {
                case MenuCadastroProduto.Produtofisico:
                    CadastrarPFisico();
                    break;
                case MenuCadastroProduto.Ebook:
                    CadstrarEbook();
                    break;
                case MenuCadastroProduto.Curso:
                    CadstrarCurso();
                    break;
            }
            Console.Clear();
        }
        static void CadastrarPFisico()
        {
            Console.WriteLine("Cadastrando Produto Físico: ");
            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Preço: ");
            float preco = float.Parse(Console.ReadLine());
            Console.WriteLine("Frete: ");
            float frete = float.Parse(Console.ReadLine());

            ProdutoFisico pf = new ProdutoFisico(nome, preco, frete);
            produtos.Add(pf);
        }

        static void CadstrarEbook()
        {
            Console.WriteLine("Cadastrando EBook: ");
            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Preço: ");
            float preco = float.Parse(Console.ReadLine());
            Console.WriteLine("Autor: ");
            string autor = Console.ReadLine();

            Ebook ebook = new Ebook(nome, preco, autor);
            produtos.Add(ebook);
        }

        static void CadstrarCurso()
        {
            Console.WriteLine("Cadastrando Curso: ");
            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Preço: ");
            float preco = float.Parse(Console.ReadLine());
            Console.WriteLine("Autor: ");
            string autor = Console.ReadLine();
            Console.WriteLine("Vagas: ");
            int vagas = int.Parse(Console.ReadLine());

            Curso cs = new Curso(nome, preco, autor, vagas);
            produtos.Add(cs);
        }


    }
}
