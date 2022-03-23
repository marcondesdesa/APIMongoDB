using System;
using System.Collections.Generic;
using System.Text;

namespace Mongo.Dominio.Entidades
{
    public class Fisica : Pessoa
    {
        
        string _cpf;
        string _rg;

        public string Cpf { get => _cpf; set => _cpf = value; }
        public string Rg { get => _rg; set => _rg = value; }
    }
}
