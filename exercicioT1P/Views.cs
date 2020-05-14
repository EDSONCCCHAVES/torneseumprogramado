using System;
using System.Threading.Tasks;

namespace exercicioT1P
{
    class Views
    {
        public static int Principal()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine(" \n \n \n \n" +
                                    "                   ============================================================================ \n" +
                                    "                   *             SISTEMA DE GESTAO DE FUNCIONARIOS                            * \n" +
                                    "                   *--------------------------------------------------------------------------* \n" +
                                    "                   *           SELECIONE A OPÇAO DESEJADA                                     * \n" +
                                    "                   *                                                                          * \n" +
                                    "                   *     1   -    CADASTRO DE PRODUTO                                         * \n" +
                                    "                   *     2   -    CADASTRO DE CLIENTE                                         * \n" +
                                    "                   *     3   -    CADASTRO DE PEDIDO                                          * \n" +
                                    "                   *     4   -    LISTAGEM DE PEDIDOS                                         * \n" +
                                    "                   *     5   -    TOTALIZAÇAO DO PEDIDO                                       * \n" +
                                    "                   *     S   -    SAIR                                                        * \n" +
                                    "                   *==========================================================================*");

                var Key = Console.ReadKey().Key;
                if (Key == ConsoleKey.D1 || Key == ConsoleKey.NumPad1)
                {
                    return 1;
                }
                else if (Key == ConsoleKey.D2 || Key == ConsoleKey.NumPad2)
                {
                    return 2;

                }
                else if (Key == ConsoleKey.D3 || Key == ConsoleKey.NumPad3)
                {
                    return 3;
                }
                else if (Key == ConsoleKey.D4 || Key == ConsoleKey.NumPad4)
                {
                    return 4;
                }
                else if (Key == ConsoleKey.D5 || Key == ConsoleKey.NumPad5)
                {
                    return 5;
                }
                else if (Key == ConsoleKey.S )
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("  Sistema Sendo Incerrado  ");
                    return 5;
                }
                else
                {
                }
            }
        }

        private static void Pausa(int v)
        {
            Task.Delay(v);
        }
    }
    
}
