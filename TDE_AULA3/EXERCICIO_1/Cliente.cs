namespace EXERCICIO_1
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public Cliente(string nome, string telefone)
        {
            this.Nome = nome;
            this.Telefone = telefone; 
        }
    }
}