using System;
using System.Collections.Generic;

namespace SEMI_AULA7
{
    public class ListaCobranca
    {
        List<Cobranca> listaDeCobranca = new List<Cobranca>();

        /*Apresenta o tamanho da lista de cobranças*/

        public int tamanhoLista()            
        {
            return listaDeCobranca.Count;
        }
        /*Retorna as cobranças cadastradas */

        public List<Cobranca> listarCobrancas()
        {
            return listaDeCobranca;    
        }

        /*Add cobranças*/

        public void addCobranca(Cobranca cobranca)
        {
            listaDeCobranca.Add(cobranca);
        }

        /*Efetuar pagamento cobranças*/

        public string efetuarPagamento(string id_cobranca)
        {
            Cobranca cobranca = null;
            cobranca = listaDeCobranca.Find(c => c.Id.Equals(id_cobranca));
            if (cobranca == null)
            {
                return"ERRO! não existe cobranças registrada";
            }
            if (cobranca.ConfirmacaoPagamento == true)
            {
                return "Essa cobrança ja foi liquidada!";
            }
            cobranca.DataPagamento = DateTime.Now.ToString("dd-MM-yyyy");
            cobranca.ConfirmacaoPagamento = true;

            return "Pagamento realizado com sucesso!\nData do pagamento: "+ cobranca.DataPagamento;
        }
    }
}