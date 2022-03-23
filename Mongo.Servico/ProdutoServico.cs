
using System;
using System.Collections.Generic;
using System.Text;
using Mongo.Dominio.Entidades;
using Mongo.Infra;
using Mongo.Infra.Repositorios;

namespace Mongo.Servico
{
    public class ProdutoServico
    {
        public (IEnumerable<Produto>, string) ObterTodos(MongoSettings mongoSettings)
        {
            return new ProdutoRepositorio(mongoSettings).ObterTodos();
        }

        public (bool,string) Salvar(MongoSettings mongoSettings, Produto produto)
        {
            return  new ProdutoRepositorio(mongoSettings).Salvar(produto);        
        }

        public (bool, string) Excluir(MongoSettings mongoSettings, string id)
        {
            return new ProdutoRepositorio(mongoSettings).Excluir(id);
        }

        public (bool, string) Atualizar(MongoSettings mongoSettings, Produto produto)
        {
            return new ProdutoRepositorio(mongoSettings).Atualizar(produto);
        }
    }
}
