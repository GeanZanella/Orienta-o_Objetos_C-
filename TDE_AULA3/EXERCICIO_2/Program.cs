using System;

/*2-  Identifique os atributos de  uma agenda	telefônica, modele as classes, 
atributos e métodos necessários para a futura implementação.*/

namespace EXERCICIO_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ControleMenuAgenda controle = new ControleMenuAgenda();
            string  operador ;

            do{
                Console.WriteLine("\nDigite 1 para add um contato: ");
                Console.WriteLine("Digite 2 para apresentar o numero de contatos cadastrados: ");
                Console.WriteLine("Digite 3 para listar todos os contatos: " );
                Console.WriteLine("Digite 4 para editar um contato: ");
                Console.WriteLine("Digite 5 para excluir um contato: ");
                Console.WriteLine("Digite 0 para encerrar: \n");

                string  resposta  =  Console.ReadLine ();

                operador = resposta;

                while(operador != "1" && operador != "2" && operador != "3" && operador != "4" 
                && operador != "5"  && operador != "0")
                {   
                    Console.WriteLine("Operação invalida digite novamente");
                    resposta = Console.ReadLine();
                    operador = resposta;
                }
                switch (operador)
                {
                    case "1" :
                        controle.criarContato();
                        break;
                    case "2" :
                        controle.printLista();
                        break;
                    case "3" :
                        controle.apresentarListaContato();
                        break;
                    case "4" :
                        controle.apresentarContatoEditado();
                        break;
                    case "5" :
                        controle.apresentarContatoRemovido();
                    break;
                }
            }while(operador != "0");
            Console.WriteLine("Programa encerrado!");
        }
    }
}
