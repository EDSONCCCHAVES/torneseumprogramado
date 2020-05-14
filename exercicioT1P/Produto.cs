using System;
using System.Collections.Generic;
using System.Text;


namespace exercicioT1P
{
    class Produto
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public int EstMinimo { get; set; }
        public double Valor { get; set; }

        public Produto(string codigo, string descricao, int quantidade, double valor)
        {
            this.Id += 1;
            Codigo = codigo;
            Descricao = descricao;
            Quantidade = quantidade;
            EstMinimo = 10;
            Valor = valor;
        }
        public static Produto Buscar(string codigo)
        {
            return DbProduto.Find(x => x.Codigo == codigo);
        }
        public static Produto BuscarId(int id)
        {
            return DbProduto.Find(x => x.Id == id);
        }
        public static void Salvar(string CodProd, string descricao, int quantidade, double valor)
        {
            DbProduto.Add(new Produto(CodProd, descricao, quantidade, valor));
        }
        public static  List<Produto> DbProduto = new List<Produto>();

    }
}
