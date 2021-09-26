using System;

/*Crie uma classe chamada ContaCorrente, que herda a interface Conta. Esta classe possui dois
atributos/propriedades chamados saldo e tarifa, do tipo double. Realize a implementação dos métodos
desta interface. Faça com que, a cada saque, seja descontado além do valor, o valor colocado no
atributo chamado tarifa. Por exemplo. Se o saldo for 100, a tarifa for 1.50 e o valor solicitado para saque
for 50, o novo saldo será 100 – 50 – 1.50 (saldo – valor – tarifa) = 48,50. Não permita sacar se o saldo for
insuficiente (não pode deixar a conta com saldo menor do que zero).*/

namespace TDE_AULA9_INTERFACE
{
    public class funcaoContaCorrente
    {
        ContaCorrente minhaConta = new ContaCorrente(1,50);
        public void fazerDeposito()
        {   
            string resposta;
            Console.WriteLine("Digite o valor do depoisto: ");
            resposta = Console.ReadLine();
            double respostaDouble = double.Parse(resposta);
            minhaConta.depositar(respostaDouble);
            Console.WriteLine("valor add com sucesso!\nSeu saldo é: " + minhaConta.Saldo);
        }
        public void fazerSaque()
        {
            string resposta;
            Console.WriteLine("Digite o valor do saque: ");
            resposta = Console.ReadLine();
            double respostaDouble = double.Parse(resposta);
            string retorno = minhaConta.sacar(respostaDouble);
            Console.WriteLine(retorno);
        }
        public void saldo()
        {
            Console.WriteLine(minhaConta.getSaldo());
        }

    }
}