namespace TDE_AULA9_INTERFACE
{
    public class GeradordeExtratos
    {
        public string GerarExtrato(IConta c)
        {
            return c.getSaldo();
        }
    }
}