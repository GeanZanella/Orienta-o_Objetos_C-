using System;
using System.Collections.Generic;

namespace EXERCICIO_1
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime DataEmissao { get; set; }  
        public Cliente Cliente { get; set; }
        public List<Item> ListaProdutos { get; set; }
        public Pedido(int id, DateTime dataEmissao, Cliente cliente, List<Item> listaProdutos)
        {
            this.Id = id;
            this.DataEmissao = dataEmissao;
            this.Cliente = cliente;
            this.ListaProdutos = listaProdutos; 
        }
    }
}