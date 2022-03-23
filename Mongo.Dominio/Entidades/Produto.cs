using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mongo.Dominio.Entidades
{
    public class Produto
    {
        string _id;
        string _descricao;
        Marca _marca;
        Double _valor;


        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get => _id; set => _id = value; }
        public string Descricao { get => _descricao; set => _descricao = value; }
        public Marca Marca { get => _marca; set => _marca = value; }
        public double Valor { get => _valor; set => _valor = value; }
    }
}
