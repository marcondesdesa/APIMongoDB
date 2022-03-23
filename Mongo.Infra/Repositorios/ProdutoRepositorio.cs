using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using Mongo.Dominio.Entidades;
using MongoDB.Driver;
using System.Threading.Tasks;

namespace Mongo.Infra.Repositorios
{
    public class ProdutoRepositorio
    {
        private readonly MongoSettings _mongoSettings;
        private readonly IMongoCollection<Produto> _produtoCollection;

        public ProdutoRepositorio(MongoSettings mongoSettings)
        {
            _mongoSettings = mongoSettings;
            _produtoCollection = _mongoSettings.Database.GetCollection<Produto>("Produtos");
        }

        public (IEnumerable<Produto>, string) ObterTodos()
        {
            IEnumerable<Produto> produtos = null;
            try
            {
                produtos = _produtoCollection.AsQueryable().Where(p => p.Id != null).ToList();
                return (produtos, "");
            }
            catch (Exception ex)
            {
                return (produtos, ex.Message);
            }
        }

        public (IEnumerable<Produto>, string) Obter(int id)
        {
            IEnumerable<Produto> produtos = null;
            try
            {
                produtos = _produtoCollection.AsQueryable().Where(p => p.Id == id.ToString()).ToList();
                return (produtos, "");
            }
            catch (Exception ex)
            {
                return (produtos, ex.Message);
            }
        }


        public (bool,string) Salvar(Produto produto)
        {
            try
            {
                _produtoCollection.InsertOne(produto);
                return (true, "");
            }
            catch (Exception ex) { 
                return (false, ex.Message); 
            }         
        }

        public (bool, string) Excluir(string id)
        {
            try
            {
                var filter = Builders<Produto>.Filter.Eq(p => p.Id, id);
                _produtoCollection.DeleteOne(filter);
                return (true, "");
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            } 
        }

        public (bool, string) Atualizar(Produto produto)
        {
            try
            {
                var filter = Builders<Produto>.Filter.Eq(p => p.Id, produto.Id);
                var update = Builders<Produto>.Update
                    .Set(p => p.Descricao, produto.Descricao)
                    .Set(p => p.Marca, produto.Marca)
                    .Set(p => p.Valor, produto.Valor);
                _produtoCollection.UpdateOne(filter, update);
                return (true, "");
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
            
        }

    }
}
