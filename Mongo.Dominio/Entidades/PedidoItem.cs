using System;
using System.Collections.Generic;
using System.Text;

namespace Mongo.Dominio.Entidades
{
    public class PedidoItem
    {
        Produto _produto;
        int _qtdeItem;
        Double _valorItem;

        public Produto Produto { get => _produto; set => _produto = value; }
        public int QtdeItem { get => _qtdeItem; set => _qtdeItem = value; }
        public double ValorItem { get => _valorItem; set => _valorItem = value; }
    }
}
