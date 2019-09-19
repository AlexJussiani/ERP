using ERP.Dominio.Contrato;
using ERP.Dominio.Entidades;
using ERP.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Repositorio.Repositorios
{
    class ItensLancheRepositorio : BaseRepositorio<ItensLanches>, IItensLanchesRepositorio
    {
        public ItensLancheRepositorio(ERPContexto erpContexto) : base(erpContexto)
       {
       }
    }
}