using ERP.Dominio.Contrato;
using ERP.Dominio.Entidades;
using ERP.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Repositorio.Repositorios
{
    class ClienteRepositorio : BaseRepositorio<Clientes>, IClientesRepositorio
    {
        public ClienteRepositorio(ERPContexto erpContexto) : base(erpContexto)
        {
        }
    }
}
