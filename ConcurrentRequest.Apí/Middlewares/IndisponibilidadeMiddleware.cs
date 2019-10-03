using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConcurrentRequest.Infra.Contrato;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;

namespace ConcurrentRequest.Apí.Middlewares
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class IndisponibilidadeMiddleware
    {
        private readonly RequestDelegate _next;
        private IIndisponibilidadeRepositorio _repositorio;

        public IndisponibilidadeMiddleware(RequestDelegate next, IIndisponibilidadeRepositorio repositorio)
        {
            _next = next;
            _repositorio = repositorio;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            IConfiguration conf = (IConfiguration)httpContext
                .RequestServices.GetService(typeof(IConfiguration));

            string mensagem = null;

            var r = _repositorio.Get(1);
            mensagem = r.Mensagem;

            if(mensagem == null )
                await _next(httpContext);
            else
            {
                httpContext.Response.StatusCode = 403;
                await httpContext.Response.WriteAsync($"<h1>{mensagem}</h1>");
            }
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class IndisponibilidadeMiddlewareExtensions
    {
        public static IApplicationBuilder UseIndisponibilidadeMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<IndisponibilidadeMiddleware>();
        }
    }
}
