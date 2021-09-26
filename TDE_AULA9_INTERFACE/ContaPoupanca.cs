namespace TDE_AULA9_INTERFACE
{
    public class ContaPoupanca:Base
    {
        public ContaPoupanca(double saldo) : base(saldo)
        {
        }

        public override void depositar(double valor)
        {
            Saldo = Saldo + valor;
        }
        public override string sacar(double valor)
        {
            if(Saldo < valor)
            {
                return "Saque Negado saldo insuficiente!";
            }
            Saldo = Saldo - valor;
            return  "Saque realizado, você sacou: " + valor + "\nSeu saldo saldo é: " + Saldo;
        }
        public override string getSaldo()
        {
            return "Seu saldo atual é: "+Saldo;
        }
    }
}