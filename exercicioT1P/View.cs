using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;

namespace exercicioT1P
{
    class View
    {
        public static void Tela2()
        {
            bool Xflag = true;
            while (Xflag==true)
            {
                string CodProd = ViewProduto();
                Produto PFlag = Produto.Buscar(CodProd);
                if (PFlag == null && int.Parse(CodProd) != 0)
                {
                    Console.Write("                   *     Digite a Descriçao do produto ................................ ");
                    string descricao = Console.ReadLine();
                    Console.Write("                   *     Digite o Valor do Produto: ................................  R$ ");
                    double valor = double.Parse(Console.ReadLine());
                    Console.Write("                   *     Digite a Quantidade: ........................................ ");
                    int quantidade = int.Parse(Console.ReadLine());
                    Produto.Salvar(CodProd, descricao, quantidade, valor);
                    Console.WriteLine("                   *==========================================================================*");
                }
                else if (Xflag == false && int.Parse(CodProd) == 0) 
                {
                    Console.Write("                   *     Saindo ..................................................... ");
                    Xflag=true;
                    break;
                }
                else if (int.Parse(CodProd) == 0 )
                {
                    Console.Write("                   *     Saindo ..................................................... ");
                    Xflag=false;
                    break;
                }
                else
                {
                    Console.Write("                   *     Produto ja cadastrado - digitar Novamente.................. ");
                    Console.ReadKey();
                    break;
                }
            }
        }
        public static void Tela3()
        {
            bool zflag = true;
            while (zflag == true )
            {
                string CodCli = ViewCliente();
                Cliente CFlag = Cliente.Buscar(CodCli);
                if (CFlag == null && int.Parse(CodCli) != 0)
                {
                    Console.Write("                   *   Digite o Nome do Cliente ................................ ");
                    string nome = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write("                   *   Digite Limite de Credito: ............................... R$");
                    double valor = double.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Cliente.Salvar( CodCli, nome, valor);
                    Console.WriteLine();
                    break;
                }
                else if (int.Parse(CodCli) == 0)
                {
                    Console.Write("                   *     Saindo ............................................. ");
                    zflag = false;
                    break;
                }
                else
                {
                    Console.Write("                   *   Cliente ja cadastrado - digitar Novamente.............. ");
                    Console.ReadKey();
                }
            }
        }
        public static void Tela4()
        {
            bool yflag = true;
            double TotalizaçaoPedido = 0.0;
            while (yflag == true)
            {
                /// Cadastro de Pedido
                string CodPed = ViewPedido();
                Pedido Flag = Pedido.Buscar(CodPed);
                if (int.Parse(CodPed) == 0)
                {
                    yflag = false;
                    break;
                }
                if ( int.Parse(CodPed) != 0)
                {
                    int IdCliente = 0;
                    while (Flag == null)
                    {
                        string CodCli = ViewCliente();
                        Cliente CFlag = Cliente.Buscar(CodCli);
                        if (CFlag != null)
                        {
                  //          IdCliente = Flag.IdCliente;
                            Console.Write("                   *    Nome do Cliente :.......................................... " + CFlag.Nome);
                            double LimiteCliente = CFlag.Limite;
                            break;
                        }
                        else if (int.Parse(CodCli) == 0)
                        {
                            Console.Write("                   *     Saindo ..................................... ");
                            yflag = false;
                            break;
                        }
                        else
                        {
                            Console.Write("                   *  Cliente Nao Cadastrado tente de novo");
                        }
                    }
                    bool dflag = true;
                    bool Uflag = true;
                    while (Flag == null && dflag == true)
                    {
                        string CodProd = ViewProduto();
                        while (Uflag == true || int.Parse(CodProd) != 0)
                        {
                            Produto PFlag = Produto.Buscar(CodProd);
                            if (PFlag != null || int.Parse(CodProd) != 0)
                            {
                                Console.Write("                   *  Descriçao do Produto:..................................................." + PFlag.Descricao + "\n");
                                int pflag = PFlag.Id;
                                var QntStq = PFlag.Quantidade;
                                double ValorProduto = PFlag.Valor;
                                Console.Write("                   *  Quantidade:.............................................................");
                                int Qnt = int.Parse(Console.ReadLine());
                                Console.WriteLine("                   *==========================================================================*");
                                while (Qnt > QntStq)
                                {
                                    Console.Write("                   *  Estoque do produto e menor que o requerido  digite outro valor");
                                    Console.Write("                   *  Quantidade:.......................................................");
                                    Qnt = int.Parse(Console.ReadLine());
                                }
                                Console.Write("                   *  Valor do Produto:.................................................    R$" + ValorProduto + "\n");
                                double valor = ValorProduto * (double)Qnt;
                                TotalizaçaoPedido = TotalizaçaoPedido + valor;
                                Console.Write("                   *  Total da Compra...................................................    R$" + valor.ToString()+"\n");
                                Pedido.Salvar(CodProd, IdCliente, pflag, Qnt, valor);
                                Console.WriteLine("                   *--------------------------------------------------------------------------*");
                         //       Console.WriteLine("                   *==========================================================================*");
                                break;
                            }
                            else if (int.Parse(CodProd) == 0)
                            {
                                Uflag = false;
                                dflag = false;
                                Console.Write("                   *  Totalizaçao do Pedido........................................" + TotalizaçaoPedido.ToString()+"\n");
                                break;
                            }
                            else
                            {
                                Console.Write("                   *  Produto não cadastrato tente novamente     ");
                            }
                            Console.WriteLine();
                        }
                        if (int.Parse(CodProd) == 0)
                        {
                            break;
                        }
                    }
                }
            }
        }
        public static void Tela5()
        {
                /// Relatorio de pedido
                string CodPed = ViewPedido();
                Pedido Flag = Pedido.Buscar(CodPed);

            Cliente CFlag = Cliente.Buscar(Flag.Numero);
            if (CFlag != null)
            {
                //          IdCliente = Flag.IdCliente;
     //           Console.Write("                   *    Nome do Cliente :............................... " + CFlag.Nome);
                Console.Write("                   *    Cliente :..." + CFlag.Numero + "  Cliente :............................... " + CFlag.Nome+"\n");
            }
                if (Flag!=null)
            {
                double TotalPedido = 0;
                Console.WriteLine("                   *==========================================================================* \n");
                Console.WriteLine("                   *-  Produto         ----*- Valor * Unitarios      *Total                   * \n");
                foreach (Pedido ped in Pedido.DbPedido)
                {
                    TotalPedido = TotalPedido + (ped.Quantidade * ped.Valor);
                    string VPedido = ped.Quantidade.ToString() + "        " + ped.Valor + "         " + (ped.Quantidade * ped.Valor).ToString();
                    Produto PFlag = Produto.BuscarId(ped.Id);
                    string DescProd = PFlag.Codigo + "        " + PFlag.Descricao;
                    Console.Write("                   *      " + DescProd + "      " + VPedido+"\n");
                }
                Console.Write(    "                   *    T O T A L I Z A Ç A O   -------------------------------------- R$ ");
                Console.Write(TotalPedido);
                Console.WriteLine();
            }
            else
            {
                Console.Write(    "                   *     Pedido não cadastrato tente novamente     ");
                Console.ReadKey();
            }
        }


        public static string ViewProduto() {
            Console.WriteLine();
            Console.Write(    "                   *     Codigo do Produto............................................... ");
            return Console.ReadLine();
        }
        public static string ViewCliente() {
            Console.WriteLine("                   *     Digite o Codigo do Cliente  ou 0(zero) pra sair................. ");
            Console.Write(    "                   *     Codigo do Cliente.............................................. ");
            return Console.ReadLine();
        }
        public static string ViewPedido() {
            Console.WriteLine("                   *     Digite o Codigo do Pedido ou 0(zero) pra sair................. ");
            Console.Write(    "                   *     Pedido :.................................................... ");
            return Console.ReadLine();


        }

    }
}
