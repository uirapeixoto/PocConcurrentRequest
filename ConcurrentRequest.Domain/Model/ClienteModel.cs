using System;
using System.Collections.Generic;
using System.Text;

namespace ConcurrentRequest.Domain.Model
{
    public class ClienteModel : ModelBase
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }
        public IEnumerable<ProdutoModel> Produto { get; set; }
    }
}
