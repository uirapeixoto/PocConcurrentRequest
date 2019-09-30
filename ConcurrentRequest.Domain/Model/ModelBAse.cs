using System;
using System.Collections.Generic;
using System.Text;

namespace ConcurrentRequest.Domain.Model
{
    public class ModelBase
    {
        public DateTime CriadoEm { get; set; }
        public DateTime AlteradoEm { get; set; }
        public int IdUsuario { get; set; }
    }
}
