using ERP.Dominio.Contrato;
using ERP.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Repositorio.Repositorios
{
    public class ClientesRepositorio : BaseRepositorio<Clientes>, IClientesRepositorio
    {
        public ClientesRepositorio(ERPContexto erpContexto) : base(erpContexto)
        {
        }
    }
}
