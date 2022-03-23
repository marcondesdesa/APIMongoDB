
using System;
using System.Collections.Generic;
using System.Text;
using Mongo.Dominio.Entidades;
using Mongo.Infra;
using Mongo.Infra.Repositorios;

namespace Mongo.Servico
{
    public class PessoaServico
    {
       
        public void Salvar()
        {
            PessoaRepositorio pessoarepositorio = null;
            pessoarepositorio.Salvar();
        }
    }
}
