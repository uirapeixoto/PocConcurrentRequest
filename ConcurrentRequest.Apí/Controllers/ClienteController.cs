using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConcurrentRequest.Domain.Model;
using ConcurrentRequest.Infra.Contrato;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConcurrentRequest.Apí.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteRepositorio _repositorio;

        public ClienteController(IClienteRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repositorio.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_repositorio.Get(id));
        }

        [HttpPost]
        public IActionResult Post([FromBody] ClienteModel model)
        {
            _repositorio.Add(model);
            return Ok(model);
        }


    }
}