using System;
using System.Collections.Generic;
using System.Text;

namespace exercicioT1P
{
    class Cliente
    {
         
        public int Id { get;  set; }
        public string Numero { get; set; }
        public string Nome { get; set; }
        public double Debito { get; set; }
        public double Limite { get; set; }

           public Cliente( string numero, string nome, double limite)
           {
               Id = this.Id + 1;
               Numero = numero;
               Nome = nome;
               Limite = limite;
               Debito = 0;
           }  
        public static Cliente Buscar(string codigo)
        {
            return  DbCliente.Find(z => z.Numero == codigo);
        }
        public static void Salvar(string Codcli, string nome, double valor )
        {
            DbCliente.Add(new Cliente(Codcli, nome, valor));
        }
        public static List<Cliente> DbCliente = new List<Cliente>();
    }
}

