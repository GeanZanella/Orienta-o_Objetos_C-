namespace EXERCICIO_3
{
    public class Livro
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }

        public Livro(int id, string nome)
        {   
            this.Id = id;   
            this.Nome = nome;
        }

        
    }
}