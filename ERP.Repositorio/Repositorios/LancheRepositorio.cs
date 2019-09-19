using ERP.Dominio.Contrato;
using ERP.Dominio.Entidades;
using ERP.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Repositorio.Repositorios
{
    class LancheRepositorio : BaseRepositorio<Lanches>, ILanchesRepositorio
    {
        public LancheRepositorio(ERPContexto erpContexto) : base(erpContexto)
        {
        }
    }
}
