using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using Mongo.Dominio.Entidades;
using MongoDB.Driver;

namespace Mongo.Infra.Repositorios
{
    public class MarcaRepositorio
    {
        private readonly MongoSettings _mongoSettings;
        private readonly IMongoCollection<Marca> _marcaColletion;
        public MarcaRepositorio(MongoSettings mongoSettings)
        {
            _mongoSettings = mongoSettings;
            _marcaColletion = _mongoSettings.Database.GetCollection<Marca>("Marcas");
        }
        public (IEnumerable<Marca>, string) ObterTodos()
        {
            IEnumerable<Marca> marcas = null;
            try
            {
                marcas = _marcaColletion.AsQueryable().Where(m => m.Id != null).ToList();
                return (marcas, "");
            }
            catch (Exception ex)
            {
                return (marcas, ex.Message);
            }
        }

        public (bool, string) Salvar(Marca marca)
        {
            try
            {
                _marcaColletion.InsertOne(marca);
                return (true, "");
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }
    }
}
