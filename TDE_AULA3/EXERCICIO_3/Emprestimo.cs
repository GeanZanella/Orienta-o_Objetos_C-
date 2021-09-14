using System;

namespace EXERCICIO_3
{
    public class Emprestimo
    {
        public int Id { get; set; }
        public DateTime DataRetirada { get; set; }
        public Livro Livro { get; set; }

        public Emprestimo(int id, DateTime dataRetirada, Livro livro)
        {
            this.Id = id;
            this.DataRetirada = dataRetirada;
            this.Livro = livro;
        }
        
    }
}