namespace SEMI_AULA7
{
    public class Cliente
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Cpf { get; set; }
        public string Endereco { get; set; }

        public Cliente()
        {

        }

        public Cliente(string id, string nome, string telefone, 
        string cpf, string endereco)
        {
            this.Id = id;
            this.Nome = nome;
            this.Telefone = telefone;
            this.Cpf = cpf;
            this.Endereco = endereco;

        }

        public string getDescription()
        {
            return "Id: " + Id + "\n Nome: " + Nome + "\n Telefone: " +Telefone+ "\n CPF: " + Cpf +
            "\n Endereço: " + Endereco;
        }
    }
}