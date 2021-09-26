/*1 – Crie uma interface chamada Conta. Conta terá os métodos depositar(double valor), sacar (double
valor), ambos void por não retornarem nenhum dado e receberem valor do tipo double para realizar
suas operações, e um método double getSaldo(), que irá retornar o valor do saldo da conta.*/


namespace TDE_AULA9_INTERFACE
{
    public interface IConta
    {
        void depositar(double valor);
        string sacar(double valor);
        string getSaldo();

    }
}