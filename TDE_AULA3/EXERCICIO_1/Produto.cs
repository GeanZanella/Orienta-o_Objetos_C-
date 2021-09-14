namespace EXERCICIO_1
{
    public class Produto
    {
        public int Id { get; private set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public decimal QuantidadeEstoque { get; set; }

        public Produto(){}
        public Produto(int id, string nome, decimal valor, decimal quantidadeEstoque)
        {
            this.Id = id;
            this.Nome = nome;
            this.Valor = valor;
            this.QuantidadeEstoque = quantidadeEstoque; 
        }
    }
}