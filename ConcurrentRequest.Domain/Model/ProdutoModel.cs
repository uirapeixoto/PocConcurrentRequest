namespace ConcurrentRequest.Domain.Model
{
    public class ProdutoModel : ModelBase
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }
        public int IdCliente { get; set; }
        public ClienteModel Cliente { get; set; }

    }
}