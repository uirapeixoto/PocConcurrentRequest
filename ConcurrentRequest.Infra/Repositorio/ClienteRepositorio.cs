using ConcurrentRequest.Domain.Model;
using ConcurrentRequest.Infra.Contexto;
using ConcurrentRequest.Infra.Contrato;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConcurrentRequest.Infra.Repositorio
{
    public class ClienteRepositorio : RepositorioBase<ClienteModel>, IClienteRepositorio
    {
        private IEnumerable<ClienteModel> _data;

        public ClienteRepositorio(DataContext context) : base(context)
        {
            _data = new List<ClienteModel>
            {
                new ClienteModel{Id = 1, Nome = "Jose da Silva", Ativo = true, CriadoEm = DateTime.Now},
                new ClienteModel{Id = 2, Nome = "Joao da Silva", Ativo = true, CriadoEm = DateTime.Now},
                new ClienteModel{Id = 3, Nome = "Antonio da Silva", Ativo = true, CriadoEm = DateTime.Now},
                new ClienteModel{Id = 4, Nome = "Maria da Silva", Ativo = true, CriadoEm = DateTime.Now}
            };
        }

        public IEnumerable<ClienteModel>  GetAll()
        {
            return _data;
        }

        public ClienteModel GetById(int id)
        {
            return _data.FirstOrDefault(x => x.Id == id);
        }
    }
}
