using System;
using System.Collections.Generic;
using System.Linq;


namespace SEMI_AULA7
{
    public class ControleCliente
    {
        ListaCliente minhaListaCliente = new ListaCliente();

        public void criarCliente()
        {
            string id_C = "";
            if (minhaListaCliente.tamanhoLista().Equals(0))
            {
                id_C = (minhaListaCliente.tamanhoLista() + 1).ToString();
            }
            else
            {
                id_C = criarIdCliente();
            }

            Console.WriteLine("Digite o nome do cliente: ");
            string nome_C = Console.ReadLine();
            Console.WriteLine("Digite o número do cliente: ");
            string numero_C = Console.ReadLine();
            Console.WriteLine("Digite o CPF do cliente: ");
            string cpf_C = Console.ReadLine();
            Console.WriteLine("Digite o endereço do cliente: ");
            string endereco_C = Console.ReadLine();

            minhaListaCliente.addCliente(new Cliente(id_C, nome_C, numero_C, cpf_C, endereco_C));

            Console.WriteLine("Cliente adicionado com sucesso!\n");

        }
        
        public string criarIdCliente()
        {
            List<Cliente> clientes = minhaListaCliente.listarClientes();
            Cliente lastCliente = clientes[clientes.Count - 1];
            string idLastCliente = lastCliente.Id;
            int idInt = int.Parse(idLastCliente);
            idInt = idInt + 1;
            
            string novoId = idInt.ToString();

            return novoId;           
        }
        public void printLista()
        {
            
            Console.WriteLine("Numero de clientes cadastrados: " + minhaListaCliente.tamanhoLista());
        }

        public void apresentarListaCliente()
        {
            List<Cliente> clientes = minhaListaCliente.listarClientes();
            if (clientes.Count == 0)
            {
                Console.WriteLine("Numero de clientes cadastrados é igual a 0! ");
            }
            else
            {
                foreach (var item in minhaListaCliente.listarClientes())
                { 
                    Console.WriteLine(item.getDescription());
                }
            }
        }
        public void apresentarClienteEditado()
        {
            if(minhaListaCliente.tamanhoLista().Equals(0))
            {
                Console.WriteLine("Lista vazia, para poder editar e necessario \n possuir clientes cadastrados");
            }
            else
            {
                Console.WriteLine("Digite o numero do id do cliente a ser editado: ");
                apresentarListaCliente();
                string idClienteEditar = Console.ReadLine();

                foreach (Cliente item in minhaListaCliente.listarClientes())
                {
                    if (item.Id.Equals(idClienteEditar))
                    {
                        Console.WriteLine("Digite o novo nome: ");
                        string novoNome = Console.ReadLine();
                        Console.WriteLine("Digite o novo telefone: ");
                        string novoTelefone = Console.ReadLine();
                        Console.WriteLine("Digite o novo CPF: ");
                        string novoCpf = Console.ReadLine();
                        Console.WriteLine("Digite o novo endereco: ");
                        string novoEndereco = Console.ReadLine();
                        
                        string retorno = minhaListaCliente.editarCliente(idClienteEditar, 
                        novoNome, novoTelefone, novoCpf, novoEndereco);
                        Console.WriteLine(retorno);
                        return;
                    }
                }
            }
        }
        public void apresentarClienteRemovido()
        {   
            if(minhaListaCliente.tamanhoLista().Equals(0))
            {
                Console.WriteLine("Lista vazia, para poder remover e necessario \n possuir clientes cadastrados");
            }
            else
            {
                Console.WriteLine("Digite o id do cliente a ser removido: ");
                apresentarListaCliente();
                string idClienteRemover = Console.ReadLine();

                string retorno = minhaListaCliente.removerCliente(idClienteRemover);
                Console.WriteLine(retorno);
            }
        }
    }
}