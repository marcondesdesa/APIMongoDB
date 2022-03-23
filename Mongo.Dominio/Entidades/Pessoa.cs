using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mongo.Dominio.Entidades
{
    public class Pessoa
    {
        string _id;
        string nome;

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get => _id; set => _id = value; }
        public string Nome { get => nome; set => nome = value; }
    }
}
