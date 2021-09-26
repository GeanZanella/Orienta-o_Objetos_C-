using System;

/*Crie uma classe chamada ContaPoupanca, que herda a interface conta. Esta classe possui um
atributos/propriedade chamado saldo, como a classe anterior (do tipo double). Realize a implementação
dos métodos desta interface. No saque, faça o mesmo procedimento como colocado no exercício 2,
porém em poupança não teremos o desconto da tarifa. Por exemplo, se o saldo é 100 e o valor do saque
for 50, o novo saldo será 100 – 50 (saldo – valor) = 50. Não permita sacar se o saldo for insuficiente (não
pode deixar a conta com saldo menor do que zero).*/

namespace TDE_AULA9_INTERFACE
{
    public class funcaoContaPoupanca
    {
        ContaPoupanca minhaContaPoupanca = new ContaPoupanca(0);
        public void fazerDepositoP()
        {   
            string resposta;
            Console.WriteLine("digite o valor do depoisto: ");
            resposta = Console.ReadLine();
            double respostaDouble = double.Parse(resposta);
            minhaContaPoupanca.depositar(respostaDouble);
            Console.WriteLine("valor add com sucesso!\nSeu saldo é: " + minhaContaPoupanca.Saldo);
        }
        public void fazerSaqueP()
        {
            string resposta;
            Console.WriteLine("digite o valor do saque: ");
            resposta = Console.ReadLine();
            double respostaDouble = double.Parse(resposta);
            string retorno = minhaContaPoupanca.sacar(respostaDouble);
            Console.WriteLine(retorno);
        }
        public void saldoP()
        {
            Console.WriteLine(minhaContaPoupanca.getSaldo());
        }
    }
}