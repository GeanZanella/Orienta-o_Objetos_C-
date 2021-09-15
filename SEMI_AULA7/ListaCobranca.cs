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
    }
}