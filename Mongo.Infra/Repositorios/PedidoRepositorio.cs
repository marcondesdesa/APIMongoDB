using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using Mongo.Dominio.Entidades;
using MongoDB.Driver;

namespace Mongo.Infra.Repositorios
{
    public class PedidoRepositorio
    {
        private readonly MongoSettings _mongoSettings;
        private readonly IMongoCollection<Pedido> _pedidoColletion;
        public PedidoRepositorio(MongoSettings mongoSettings)
        {
            _mongoSettings = mongoSettings;
        }
        public void Salvar()
        {

        }
    }
}
