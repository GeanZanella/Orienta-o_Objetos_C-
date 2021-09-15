using System;
using System.Collections.Generic;

namespace SEMI_AULA7
{
    public class Cobranca
    {
        public string Id { get; set; }
        public DateTime DataEmissao { get; set; }
        public DateTime DataVencimento { get; set; }
        public string DataPagamento { get; set; }
        public bool ConfirmacaoPagamento { get; set; }
        public double Valor { get; set; }
        public Cliente Cliente_ { get; set; }

        public Cobranca()
        {

        }
        
        public Cobranca(string id, DateTime dataEmissao, DateTime dataVencimento, double valor, Cliente cliente_)
        {
            this.Id = id;
            this.DataEmissao = dataEmissao;
            this.DataVencimento = dataVencimento;
            this.DataPagamento = "";
            this.ConfirmacaoPagamento = false;
            this.Valor = valor;
            this.Cliente_ = cliente_;
        }
        public string getDescription()
        {
            return "Id: " + Id + "\n Data Emissão: " + DataEmissao + "\n Data Vencimento: " + DataVencimento + 
            "\n Data Pagamento: " + DataPagamento + "\n Confirmação Pagamento: " + ConfirmacaoPagamento + 
            "\n Valor: " + Valor + "\n Cliente: " + Cliente_.Nome;
        }
    }
}