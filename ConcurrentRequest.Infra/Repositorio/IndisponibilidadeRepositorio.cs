using ConcurrentRequest.Domain.Model;
using ConcurrentRequest.Infra.Contexto;
using ConcurrentRequest.Infra.Contrato;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConcurrentRequest.Infra.Repositorio
{
    public class IndisponibilidadeRepositorio : RepositorioBase<IndisponibilidadeModel>, IIndisponibilidadeRepositorio
    {
        private IEnumerable<IndisponibilidadeModel> _data;

        public IndisponibilidadeRepositorio(DataContext context) : base(context)
        {
            _data = new List<IndisponibilidadeModel>
            {
                new IndisponibilidadeModel{Id = 1, Inicio = DateTime.Now.AddHours(-2), Fim = DateTime.Now.AddHours(2), Mensagem = "Sistema indisponivel"},
            };
        }

    }
}
