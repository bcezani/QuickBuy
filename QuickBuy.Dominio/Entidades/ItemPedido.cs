namespace QuickBuy.Dominio.Entidades
{
    public class ItemPedido : Entidade
    {
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
    }
}