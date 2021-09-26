using System;

namespace TDE_AULA9_INTERFACE
{
    class Program
    {
        static void Main(string[] args)
        {
            funcaoContaCorrente controle = new funcaoContaCorrente();
            funcaoContaPoupanca controle_ = new funcaoContaPoupanca();
            funcaoGeradorExtrato controle__ = new funcaoGeradorExtrato();
            string  operador ;

            do{
                Console.WriteLine("\nDigite 1 para fazer deposito em conta corrente: ");
                Console.WriteLine("Digite 2 para fazer deposito em poupança: ");
                Console.WriteLine("Digite 3 para ver o saldo da conta corrente: ");
                Console.WriteLine("Digite 4 para ver o saldo da poupança: ");
                Console.WriteLine("Digite 5 para sacar da conta corrente: " );
                Console.WriteLine("Digite 6 para sacar da poupança: " );
                Console.WriteLine("Digite 7 para ver o extrato: " );
                Console.WriteLine("Digite 0 para encerrar: \n");

                string  resposta  =  Console.ReadLine ();

                operador = resposta;


                while(operador != "1" && operador != "2" && operador != "3" && operador != "4" 
                && operador != "5" && operador != "6" && operador != "7" && operador != "0")
                {   
                    Console.WriteLine("Operação invalida digite novamente");
                    resposta = Console.ReadLine();
                    operador = resposta;
                }
                switch (operador)
                {
                    case "1" :
                        controle.fazerDeposito();
                        break;
                    case "2" :
                        controle_.fazerDepositoP();
                        break;
                    case "3" :
                        controle.saldo();
                        break;
                    case "4" :
                        controle_.saldoP();
                        break;
                    case "5" :
                        controle.fazerSaque();
                        break;
                    case "6" :
                        controle_.fazerSaqueP();
                        break;
                    case "7" :
                        controle__.apresentarExtrato();
                        break;
                }
            }while(operador != "0");
            Console.WriteLine("Programa encerrado!");
        }
    }
}
