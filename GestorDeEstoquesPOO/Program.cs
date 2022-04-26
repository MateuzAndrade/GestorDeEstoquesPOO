using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeEstoquesPOO
{
    internal class Program
    {
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

            }

        }


        static void Cadastro()
        {
            bool EscolheuSairCadastro = false;

            while (!EscolheuSairCadastro)
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

                if (Opselec > 0 && Opselec < 3)
                {
                    switch (Escolha)
                    {
                        case MenuCadastroProduto.Produtofisico:
                            break;
                        case MenuCadastroProduto.Ebook:
                            break;
                        case MenuCadastroProduto.Curso:
                            break;
                        default:
                            break;
                    }
                }
                g


            }

        }
    }
}
