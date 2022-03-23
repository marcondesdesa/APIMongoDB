using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mongo.Dominio.Entidades
{
    public class Pedido
    {
        string _id;
        DateTime _dataPedido;
        Double _valorPedido;
        List<PedidoItem> _items;

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get => _id; set => _id = value; }
        public DateTime DataPedido { get => _dataPedido; set => _dataPedido = value; }
        public double ValorPedido { get => _valorPedido; set => _valorPedido = value; }
        public List<PedidoItem> Items { get => _items; set => _items = value; }
    }
}
