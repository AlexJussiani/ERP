﻿using ERP.Dominio.Contrato;
using ERP.Dominio.Entidades;
using ERP.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Repositorio.Repositorios
{
    class IngredienteRepositorio : BaseRepositorio<Ingredientes>, IIngredientesRepositorio
    {

        public IngredienteRepositorio(ERPContexto erpContexto) : base(erpContexto)
        {
        }
    }
}
