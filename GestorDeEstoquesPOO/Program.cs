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
    }
}
