using System;

/* Crie uma outra classe chamada GeradordeExtratos, que possui um método que recebe a interface
Conta como parâmetro, chamado GerarExtrato (Conta c), que mostre o saldo de qualquer uma das duas
contas. (para isso, deve chamar c.getSaldo()).*/

namespace TDE_AULA9_INTERFACE
{
    public class funcaoGeradorExtrato
    {
        GeradordeExtratos extrato = new GeradordeExtratos();
        public void apresentarExtrato()
        {
            ContaCorrente saldoCorrente = null;
            ContaPoupanca saldoPoupanca = null;
            Console.WriteLine(extrato.GerarExtrato(saldoCorrente));
            Console.WriteLine(extrato.GerarExtrato(saldoPoupanca));
        }

    }
}