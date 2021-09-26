namespace TDE_AULA9_INTERFACE
{
    public abstract class Base : IConta
    {
        public double Saldo { get; set; }
        public Base(double saldo)
        {
            this.Saldo = saldo;
        }
        public virtual void depositar(double valor)
        {

        }
        public virtual string sacar(double valor)
        {
            return "";
        }
        public virtual string getSaldo()
        {
            return "";
        }

    }
}