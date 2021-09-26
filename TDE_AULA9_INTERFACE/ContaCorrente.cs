
namespace TDE_AULA9_INTERFACE
{
    public class ContaCorrente:Base
    {
        public double Tarifa { get; set; }

        public ContaCorrente(double tarifa, double saldo) : base(saldo)
        {
                this.Tarifa = tarifa;
        }       
        public override void depositar(double valor)
        {
            Saldo = Saldo + valor;
        }

        public override string sacar(double valor)
        {
            double saqueMaisTarifa = valor + Tarifa;

            if(Saldo < saqueMaisTarifa)
            {
                return "Saque Negado saldo insuficiente!";
            }
            Saldo = Saldo - saqueMaisTarifa;

            return  "Saque realizado, você sacou: " + valor + "\nSeu saldo saldo é: " + Saldo;
        }
        public override string getSaldo()
        {
            return "Seu saldo atual é: "+Saldo;
        }
    }
}