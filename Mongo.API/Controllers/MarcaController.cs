using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mongo.Dominio.Entidades;
using Mongo.Infra.Repositorios;
using Mongo.Servico;
using Mongo.Infra;

namespace Mongo.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MarcaController : ControllerBase
    {
        private readonly AppSettings _appSettings;
        private readonly MarcaServico _marcaServico;
        private readonly MongoSettings _mongoSettings;

        public MarcaController(AppSettings appSettings, MarcaServico marcaServico, MongoSettings mongoSettings)
        {
            _appSettings = appSettings;
            _marcaServico = marcaServico;
            _mongoSettings = mongoSettings;
        }
        [HttpGet]
        public IActionResult ObterTodos()
        {
            string mems = "";
            IEnumerable<Marca> marcs = null;
            (marcs, mems) = _marcaServico.ObterTodos(_mongoSettings);
            var obj = new
            {
                marcas = marcs,
                memsagem = mems
            };
            return Ok(obj);
        }

        [HttpGet]
        public IActionResult Salvar()
        {
            bool oper = false;
            string mems = "";
            Marca m1 = new Marca();
            m1.Nome = "Marca 3";
            (oper, mems) = _marcaServico.Salvar(_mongoSettings, m1);
            var obj = new
            {
                operacao = oper,
                memsagem = mems
            };
            return Ok(obj);
        }
    }
}
