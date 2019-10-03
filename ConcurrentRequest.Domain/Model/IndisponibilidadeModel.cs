using System;
using System.Collections.Generic;
using System.Text;

namespace ConcurrentRequest.Domain.Model
{
    public class IndisponibilidadeModel
    {
        public int Id { get; set; }
        public DateTime Inicio {get; set;}
        public DateTime Fim { get; set; }
        public string Mensagem { get; set; }
        public bool Ativo { get; set; }
    }
}
