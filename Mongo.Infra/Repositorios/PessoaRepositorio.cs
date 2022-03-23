
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using Mongo.Dominio.Entidades;
using MongoDB.Driver;

namespace Mongo.Infra.Repositorios
{
    public class PessoaRepositorio
    {
        private readonly MongoSettings _mongoSettings;
        private readonly IMongoCollection<Pessoa> _pessoaColletion;
        public PessoaRepositorio(MongoSettings mongoSettings)
        {
            _mongoSettings = mongoSettings;
        }
        public void Salvar()
        {

        }
    }
}
