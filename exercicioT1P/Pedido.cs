using System.Collections.Generic;
using System.Globalization;


namespace exercicioT1P
{
    class Pedido
    {

        public int Id { get;  private set; }
        public string Numero { get; set; }
        public int IdCliente { get; set; }
        public int Idproduto { get; set; }
        public int Quantidade { get; set; }
        public double Valor { get; set; }

        public Pedido( string numero, int idCliente, int idproduto, int quantidade, double valor)
        {
            this.Id += 1;
            Numero = numero;
            IdCliente = idCliente;
            Idproduto = idproduto;
            Quantidade = quantidade;
            Valor = valor;
        }
        public static Pedido Buscar(string codigo)
        {
            return  DbPedido.Find(y => y.Numero == codigo);
        }
        public static void Salvar(string numero, int idCliente, int idproduto, int quantidade, double valor)
        {
            DbPedido.Add(new Pedido(numero,  idCliente,  idproduto,  quantidade,  valor));
        }

        public static List<Pedido> DbPedido = new List<Pedido>();
    }

}

