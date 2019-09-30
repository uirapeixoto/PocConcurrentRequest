using ConcurrentRequest.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConcurrentRequest.Infra.Contrato
{
    public interface IClienteRepositorio
    {
         IEnumerable<ClienteModel> GetAll();
         ClienteModel Get(int id);
         ClienteModel GetById();
         ClienteModel Add();

    }
}
