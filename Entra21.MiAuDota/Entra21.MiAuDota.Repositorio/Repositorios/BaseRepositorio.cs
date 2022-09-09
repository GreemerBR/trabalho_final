﻿using Entra21.MiAuDota.Repositorio.BancoDados;
using Entra21.MiAuDota.Repositorio.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Entra21.MiAuDota.Repositorio.Repositorios
{
    public class BaseRepositorio<TEntity>
        : IBaseRepositorio<TEntity>
        where TEntity : BaseEntity
    {
        private readonly MiAuDotaContexto _contexto;

        public BaseRepositorio(MiAuDotaContexto contexto)
        {
            _contexto = contexto;
        }

        public virtual bool Apagar(int id)
        {
            var entity = ObterPorId(id);

            if (entity == null)
                return false;

            _contexto.Entry<TEntity>(entity).State = EntityState.Deleted;
            _contexto.SaveChanges();

            return true;

        }

        public virtual TEntity Cadastrar(TEntity entity)
        {
            _contexto.Set<TEntity>().Add(entity);
            _contexto.SaveChanges();

            return entity;
        }

        public virtual void Editar(TEntity entity)
        {
            _contexto.Entry<TEntity>(entity).State = EntityState.Modified;
        }

        public virtual TEntity? ObterPorId(int id)
        {
            TEntity model = null;

            model = _contexto.Set<TEntity>().Find(id);

            return model;
        }

        public virtual IList<TEntity> ObterTodos()
        {
            IList<TEntity> list = new List<TEntity>();

            list = _contexto.Set<TEntity>().ToList();

            return list;
        }

        public virtual IList<TEntity> ObterTodosComFiltro(string pesquisa) => ObterTodos();
    }
}