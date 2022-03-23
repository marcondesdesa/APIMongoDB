
using System;
using System.Collections.Generic;
using System.Text;
using Mongo.Dominio.Entidades;
using Mongo.Infra;
using Mongo.Infra.Repositorios;

namespace Mongo.Servico
{
    public class MarcaServico
    {
        public (IEnumerable<Marca>, string) ObterTodos(MongoSettings mongoSettings)
        {
            return new MarcaRepositorio(mongoSettings).ObterTodos();
        }

        public (bool, string) Salvar(MongoSettings mongoSettings, Marca marca)
        {
            return new MarcaRepositorio(mongoSettings).Salvar(marca);
        }
    }
}
