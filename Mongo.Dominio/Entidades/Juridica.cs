using System;
using System.Collections.Generic;
using System.Text;

namespace Mongo.Dominio.Entidades
{
    public class Juridica : Pessoa
    {
        string _cnpj;
        string _inscricaoEstadual;

        public string Cnpj { get => _cnpj; set => _cnpj = value; }
        public string InscricaoEstadual { get => _inscricaoEstadual; set => _inscricaoEstadual = value; }

    }
}
