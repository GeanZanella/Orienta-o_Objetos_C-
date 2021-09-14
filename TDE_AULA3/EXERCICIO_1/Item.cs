namespace EXERCICIO_1
{
    public class Item
    {
        public Pedido Pedido { get; set; }
        public Produto Produto { get; set; }
        public decimal Quantidade { get; set; }
        public decimal Desconto { get; set; }

         public Item(Pedido pedido, Produto produto, decimal quantidade, decimal desconto)
        {
            this.Pedido = pedido;
            this.Produto = produto;
            this.Quantidade = quantidade;
            this.Desconto = desconto; 
        }

    }
}