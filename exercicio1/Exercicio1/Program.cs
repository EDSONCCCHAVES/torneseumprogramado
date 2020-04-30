using System;
using System.Collections.Generic;
using System.Collections;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            var Funcionarios = new ArrayList();
//            var Funcionarios = new List<Funcionario>();  //  este ok 
            //          var F = new Funcionario();
            var Funcionario = new Funcionario();
            Funcionario F = new Funcionario();
            while (true)
            {
                Console.Clear();
                Console.WriteLine(" \n \n \n \n" +
                                  "                   ============================================================================ \n" +
                                  "                   *             SISTEMA DE GESTAO DE FUNCIONARIOS                            * \n" +
                                  "                   *--------------------------------------------------------------------------* \n" +
                                  "                   *           SELECIONE A OPÇAO DESEJADA                                     * \n" +
                                  "                   *                                                                          * \n" +
                                  "                   *     0   -    CADASTRO DE FUNCIONARIO                                     * \n" +
                                  "                   *     1   -    LISTAGEM DE FUNCIONARIOS                                    * \n" +
                                  "                   *     2   -    LISTAGEM DE FUNCIONARIOS COM SALARIOS                       * \n" +
                                  "                   *     3   -    LISTAGEM DE FUNCIONARIOS, VALE, SALARIOSEMVALE              * \n" +
                                  "                   *     4   -    LISTAGEM DE VALORES A PAGAR NO MES                          * \n" +
                                  "                   *     S   -    SAIR                                                        * \n" +
                                  "                   *==========================================================================*");

                var Key = Console.ReadKey().Key;
                Console.Clear();
                Console.WriteLine(" \n \n \n \n" +
                  "                   ============================================================================ \n" +
                  "                   *             SISTEMA DE GESTAO DE FUNCIONARIOS                            * \n" +
                  "                   *--------------------------------------------------------------------------* \n" +
                  "                   *                                                                          * ");

                if (Key == ConsoleKey.D0 || Key == ConsoleKey.NumPad0)
                {
                    while (true)
                    {
                                               int Codigo = F.GetCodigo(" ", "                   *  Dado invalido - Favor Digitar um Valor Numerico                         *");
                        Console.WriteLine("                   *  ----------------------------------------------------------------------- *");
                        if (Codigo == 0) break;
                        //                     Funcionario.Id_fnc = Codigo;
                        F.Id_fnc = Codigo;
                        Console.WriteLine("                  *            Digite o Nome do Funcionario       *");
                        string Nome = Console.ReadLine();
                        F.Nme_fun = Nome;
                        double Salario = F.GetSalario(" ", "                   *  Dado invalido - Favor Digitar um Valor Numerico                         *");
                        Console.WriteLine("                   *  ----------------------------------------------------------------------- *");
                        //                        Funcionario.Slr_Fnc = Salario;
                        F.Slr_Fnc = Salario;
                        Funcionarios.Add(Codigo);
                        Funcionarios.Add(Nome);
                        Funcionarios.Add(Salario);
 //                       Funcionarios.Add(F);
                    }
                }
                else if (Key == ConsoleKey.D1 || Key == ConsoleKey.NumPad1)
                {
                    // imprimir codigo nome e salario 
                    int QtdFuncionario = Funcionarios.Count;
                    Console.WriteLine("                   *  Cadastro        Nome Funcionario      Salario----------------------------*");
                    int Contador =( Funcionarios.Count), i = 0;
                    do
                    {
                        Console.Write("                   *  ");
                        Console.Write(Funcionarios[i]);
                        i++;
                        Console.Write("             ");
                        Console.Write(Funcionarios[i]);
                        Console.Write("                 ");
                        i++;
                        Console.Write(Funcionarios[i]);
                        Console.WriteLine("        ");

                        i++;

                    } while (i < Contador);
                    Console.WriteLine("                   *  ======================================================================= *");
                    Console.WriteLine("                   *                           precione qualquer tecla pra sair              *");
                    Console.ReadKey();

                }
                else if (Key == ConsoleKey.D2 || Key == ConsoleKey.NumPad2)
                {
                    // imprimir codigo nome e salario e Vale
                    int QtdFuncionario = Funcionarios.Count;
                    Console.WriteLine("                   *  Cadastro        Nome Funcionario      Salario     Vale - - - -------------*");
                    int Contador = (Funcionarios.Count), i = 0;

                    do
                    {
                        Console.Write("                   *  ");
                        Console.Write(Funcionarios[i]);
                        i++;
                        Console.Write("             ");
                        Console.Write(Funcionarios[i]);
                        Console.Write("                 ");
                        i++;
                        Console.Write(Funcionarios[i]);
                        Console.Write("        ");
                        
                        var Xvalor = Funcionarios[i];
                        Double Zvalor = Convert.ToDouble((Funcionarios[i]));
                        double DValor = F.CalculoVale(Zvalor);
                        Console.Write(DValor);
                        Console.WriteLine("        ");
                        i++;

                    } while (i < Contador);
                    Console.WriteLine("                   *  ======================================================================= *");
                    Console.WriteLine("                   *                           precione qualquer tecla pra sair              *");
                    Console.ReadKey();
                }
                else if (Key == ConsoleKey.D3 || Key == ConsoleKey.NumPad3)
                {
                    // imprimir codigo nome e salario e Vale SALARIOSEMVALE
                    int QtdFuncionario = Funcionarios.Count;
                    Console.WriteLine("                   *  Cadastro        Nome Funcionario      Salario     Vale - - ------------*");
                    int Contador = (Funcionarios.Count), i = 0;

                    do
                    {
                        Console.Write("                   *  ");
                        Console.Write(Funcionarios[i]);
                        i++;
                        Console.Write("             ");
                        Console.Write(Funcionarios[i]);
                        Console.Write("                 ");
                        i++;
                        Console.Write(Funcionarios[i]);
                        Console.Write("        ");

                        Double Zvalor = Convert.ToDouble((Funcionarios[i]));
                        double DValor = F.CalculoVale(Zvalor);
                        Console.Write(DValor);
                        Console.Write("        ");

  //                      Double Uvalor = Convert.ToDouble((Funcionarios[i]));
                        double UValor = F.SalarioSemVale(Zvalor);
                        Console.Write(UValor);

                        Console.WriteLine("        ");
                        i++;

                    } while (i < Contador);
                    Console.WriteLine("                   *  ======================================================================= *");
                    Console.WriteLine("                   *                           precione qualquer tecla pra sair              *");
                    Console.ReadKey();
                }
                else if (Key == ConsoleKey.D4 || Key == ConsoleKey.NumPad4)
                {
                    // imprimir codigo nome e salario e Vale SALARIOSEMVALE valores a pagar no mes
                    int QtdFuncionario = Funcionarios.Count;
                    Console.WriteLine("                   *  Cadastro        Nome Funcionario      Salario     Vale       Sem Vale--- *");
                    int Contador = (Funcionarios.Count), i = 0;
                    double TSalarios = 0, TVale = 0, TSVale = 0;
                    do
                    {

                        Console.Write("                   *  ");
                        Console.Write(Funcionarios[i]);
                        i++;
                        Console.Write("             ");
                        Console.Write(Funcionarios[i]);
                        Console.Write("                 ");
                        i++;
                        Console.Write(Funcionarios[i]);
                        Console.Write("        ");

                        Double Zvalor = Convert.ToDouble((Funcionarios[i]));
                        double DValor = F.CalculoVale(Zvalor);
                        Console.Write(DValor);
                        Console.Write("        ");


                        //                      Double Uvalor = Convert.ToDouble((Funcionarios[i]));
                        double UValor = F.SalarioSemVale(Zvalor);
                        Console.Write(UValor);
                        TSalarios = +TSalarios + Zvalor;
                        TVale = TVale + DValor;
                        TSVale = TSVale + UValor;

                        Console.WriteLine("        ");
                        i++;

                    } while (i < Contador);
                    Console.WriteLine("                   *  ======================================================================= *");
                    Console.WriteLine("                   *  *  - - - T o t a l i z a c a o  - - - - - - - - - - - - - - - - - - - - *");

                    Console.Write("                   *                                        ");
                    Console.Write(TSalarios);
                    Console.Write("        ");
                    Console.Write(TVale);
                    Console.Write("        ");
                    Console.Write(TSVale);
                    Console.WriteLine("        ");

                    //                  Console.WriteLine("                   *  Totalizacao  ======================================================================= *");
                    Console.WriteLine("                   *  ======================================================================= *");
                    Console.WriteLine("                   *                           precione qualquer tecla pra sair              *");
                    Console.ReadKey();
                }
                else if (Key == ConsoleKey.S)
                {
                    break;
                }
                else
                    Console.WriteLine("                   *          opçao inexistente      *");

            }
        }
    }
    public class Funcionario
    {
        public int Id_fnc;
        public string Nme_fun;
        public double Slr_Fnc;

        /// <summary>
        /// Vale e Igual   Salario - 30%
        /// </summary>
        /// <param name="Salario"></param>
        /// <returns></returns>
        /*public Funcionario()
        {

        }
        public Funcionario ( int _Id_fnc, string _Nme_fun, double _Slr_fnc) 
        {
                this.F_Id_fnc = _Id_fnc;
                this.F_Nme_fun = _Nme_fun;
                this.F_Slr_fnc = _Slr_fnc;
        }
        */
        //public int F_Id_fnc = 0;
        //public string F_Nme_fun = String.Empty;
        //public double F_Slr_fnc = 0.00;
        public double CalculoVale(double Salario)
        {
            double Vale = Salario - (Salario * 30 / 100);
            return Vale;

        }
        public double SalarioSemVale(double Salario)
        {
            double SemVale = Salario - (Salario * 70 / 100);
            return SemVale;

        }

        public int GetCodigo(string texto, string mensagemDeErro)
        {
            Console.WriteLine("                   *  Digite o Numero do Cadastro do Funcionario   ou 0(zero) pra finalizar   *");
            Console.WriteLine("                   *  ----------------------------------------------------------------------- *");

            string input = Console.ReadLine();
            int valor = 0;

            if (int.TryParse(input, out valor))
            {
                return valor;
            }
            else
            {
                System.Console.WriteLine(mensagemDeErro);
                return GetCodigo(texto, mensagemDeErro);
            }
        }

        public double GetSalario(string texto, string mensagemDeErro)
        {
            Console.WriteLine("                   *      Digite o Salario do Funcionario                                     *");
            Console.WriteLine("                   *  ----------------------------------------------------------------------- *");

 //           int input[] = Console.Read();
 //           string ch = Convert.ToChar(input);
            string input = Console.ReadLine(); 
            double valor = 0;

            if (double.TryParse(input, out valor))
            {
                return valor;
            }
            else
            {
                System.Console.WriteLine(mensagemDeErro);
                return GetSalario(texto, mensagemDeErro);
            }
        }
    }
}