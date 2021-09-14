using System;
using System.Collections.Generic;

namespace SEMI_AULA7
{
    public class Cobranca
    {
        public int Id { get; set; }
        public DateTime DataEmissao { get; set; }
        public DateTime DataVencimento { get; set; }
        public DateTime DataPagamento { get; set; }
        public double Valor { get; set; }
        public Cliente Cliente_ { get; set; }

        public Cobranca()
        {

        }
        
        public Cobranca(int id, DateTime dataEmissao, DateTime dataVencimento,
         DateTime dataPagamento, double valor, Cliente cliente_)
        {
            this.Id = id;
            this.DataEmissao = dataEmissao;
            this.DataVencimento = dataVencimento;
            this.DataPagamento = dataPagamento;
            this.Valor = valor;
            this.Cliente_ = cliente_;
        }
    }
}