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
    public class ProdutoController : ControllerBase
    {
        private readonly AppSettings _appSettings;
        private readonly ProdutoServico _produtoServico;
        private readonly MongoSettings _mongoSettings;

        public ProdutoController(AppSettings appSettings, ProdutoServico produtoservico, MongoSettings mongoSettings)
        {
            _appSettings = appSettings;
            _produtoServico = produtoservico;
            _mongoSettings = mongoSettings;
        }

        [HttpGet]
        public IActionResult ObterTodos()
        {
            string mems = "";
            IEnumerable<Produto> prods = null;
            (prods, mems) = _produtoServico.ObterTodos(_mongoSettings);
            var obj = new
            {
                produtos = prods,
                memsagem = mems
            };
            return Ok(obj);
        }

        [HttpGet]
        public IActionResult Salvar()
        {
            bool oper = false;
            string mems = "";
            Produto p1 = new Produto();
            p1.Descricao = "Produto 3";
            p1.Valor = 30.00;
            p1.Marca = new Marca();

            (oper, mems) = _produtoServico.Salvar(_mongoSettings, p1);
            var obj = new
            {
                operacao = oper,
                memsagem = mems
            };
            return Ok(obj);
        }


    }
}
