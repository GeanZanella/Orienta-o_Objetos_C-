using System;
using System.Collections.Generic;

namespace EXERCICIO_2
{
    public class Agenda
    {
        List<Contato> listaDeContatos = new List<Contato>();

            /*Add Contato*/
        public void addContato(Contato contato)
        {
            listaDeContatos.Add(contato);
        }

            /*Apresenta o tamanho da lista de contatos*/
        public int tamanhoLista()
        {
            return listaDeContatos.Count;
        }

            /*Apresenta os contatos cadastrados */
        public List<Contato> listarContato()
        {
            return listaDeContatos;    
        }

            /*Editar clientes cadastrados*/
        public string editarContato(string idContato, string nomeEditado, string telefoneEditado)
        {
            Contato contatoEditar = null;
            contatoEditar = listaDeContatos.Find(c => c.Id.Equals(idContato));
            if(contatoEditar == null)
            {
                return "ERRO! Contato nexistente!";
            }

            contatoEditar.Nome = nomeEditado;
            contatoEditar.Numero = telefoneEditado;

            return "Contato editado com sucesso!";
        }

            /*Remover Contato*/
        public string removerContato(string idRemover)
        {
            int contatoRemovido = listaDeContatos.FindIndex(c => c.Id.Equals(idRemover));

            if (contatoRemovido.Equals(-1))
            {
                return "ERRO, cliente inexistente";
            }

            listaDeContatos.RemoveAt(contatoRemovido);

            return "Contato removido com sucesso!";
        }
    }    
}