using System;
using System.Collections.Generic;
using System.Linq;

namespace EXERCICIO_2
{
  public class ControleMenuAgenda
  {
    Agenda minhaAgenda = new Agenda();
    public void criarContato()
    {
      string id_C = "";
      if (minhaAgenda.tamanhoLista().Equals(0))
      {
        id_C = (minhaAgenda.tamanhoLista() + 1).ToString();
      }
      else
      {
        id_C = criarIdContato();
      }
        Console.WriteLine("Digite o nome do contato: ");
        string nome_C = Console.ReadLine();
        Console.WriteLine("Digite o número do contato: ");
        string numero_C = Console.ReadLine();
 
        minhaAgenda.addContato(new Contato(id_C, nome_C, numero_C));

        Console.WriteLine("Contato adicionado com sucesso!\n");
      }
        
    public string criarIdContato()
    {
      List<Contato> contatos = minhaAgenda.listarContato();
      
      Contato lastContato = contatos[contatos.Count - 1];
      string idLastContato = lastContato.Id;
      int idInt = int.Parse(idLastContato);
      idInt = idInt + 1;
            
      string novoId = idInt.ToString();

      return novoId;           
    }
    public void printLista()
    { 
        Console.WriteLine("Numero de clientes cadastrados: " + minhaAgenda.tamanhoLista());
    }
    public void apresentarListaContato()
    {
      List<Contato> contatos = minhaAgenda.listarContato();
      if (contatos.Count == 0)
      {
        Console.WriteLine("Numero de clientes cadastrados é igual a 0! ");
      }
      else
      {
        foreach (var item in minhaAgenda.listarContato())
        { 
          Console.WriteLine(item.getDescription());
        }
      }
    }
    public void apresentarContatoEditado()
    {
      if(minhaAgenda.tamanhoLista().Equals(0))
      {
        Console.WriteLine("Lista vazia, para poder editar e necessario \n possuir contatos cadastrados");
      }
      else
      {
        Console.WriteLine("Digite o numero do id do contato a ser editado: ");
        apresentarListaContato();
        string idClienteEditar = Console.ReadLine();
        
        foreach (Contato item in minhaAgenda.listarContato())
        {
          if (item.Id.Equals(idClienteEditar))
          {
            Console.WriteLine("Digite o novo nome: ");
            string novoNome = Console.ReadLine();
            Console.WriteLine("Digite o novo telefone: ");
            string novoTelefone = Console.ReadLine();
            string retorno = minhaAgenda.editarContato(idClienteEditar, novoNome, novoTelefone);
            Console.WriteLine(retorno);
            return;
          }
        }
      }
    }
    public void apresentarContatoRemovido()
    {   
      if(minhaAgenda.tamanhoLista().Equals(0))
      {
        Console.WriteLine("Lista vazia, para poder remover e necessario \n possuir contatos cadastrados");
      }
      else
      {
        Console.WriteLine("Digite o id do contato a ser removido: ");
        apresentarListaContato();
        string idContatoRemover = Console.ReadLine();
        string retorno = minhaAgenda.removerContato(idContatoRemover);
        Console.WriteLine(retorno);
      }
    }
  }
}