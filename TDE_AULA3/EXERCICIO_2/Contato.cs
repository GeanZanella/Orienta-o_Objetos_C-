namespace EXERCICIO_2
{
    public class Contato
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public string Numero { get; set; }
        public Contato(string id, string nome, string numero)
        {
            this.Id = id;
            this.Nome = nome;
            this.Numero = numero;
        }
        public string getDescription()
        {
            return "Id: " + Id + " - " + Nome + " -  Número: " + Numero;
        }
    }
}

        /*
        public string getNome()
        {
        return this.nome;
        }

        public void setNome(string nome)
        {
        this.nome = nome;
        }
        */