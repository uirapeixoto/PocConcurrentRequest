using ConcurrentRequest.Infra.Contexto;
using ConcurrentRequest.Infra.Contrato;
using ConcurrentRequest.Infra.Repositorio;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace ConcurrentRequest.IoC
{
    public class CarregaIoC
    {
        public static void RegistraServicos(IServiceCollection services)
        {
            services.AddScoped<DataContext>();

            #region Service
            #endregion

            #region Repository
            services.AddScoped<IClienteRepositorio, ClienteRepositorio>();
            #endregion
        }
    }
}
