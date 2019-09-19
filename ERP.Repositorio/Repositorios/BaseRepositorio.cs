using ERP.Dominio.Contrato;
using ERP.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ERP.Repositorio.Repositorios
{
    public class BaseRepositorio<TEntity> : IBaseRepositorio<TEntity> where TEntity : class                
    {
        protected readonly ERPContexto erpContexto;

        public BaseRepositorio(ERPContexto erpContexto)
        {
            this.erpContexto = erpContexto;
        }

        public void Adicionar(TEntity entity)
        {
        erpContexto.Set<TEntity>().Add(entity);
        erpContexto.SaveChanges();
    }

        public void Atualizar(TEntity entity)
        {
            erpContexto.Set<TEntity>().Update(entity);
            erpContexto.SaveChanges();
        }

        public void Dispose()
        {
            erpContexto.Dispose();
        }

        public TEntity ObterPorId(int id)
        {
            return erpContexto.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return erpContexto.Set<TEntity>().ToList();
        }

        public void Remover(TEntity entity)
        {
            erpContexto.Remove(entity);
            erpContexto.SaveChanges();
        }
    }
}
