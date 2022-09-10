﻿using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Repositorio.Repositorios;
using Entra21.MiAuDota.Servico.MapeamentoEntidades;
using Entra21.MiAuDota.Servico.ViewModels;

namespace Entra21.MiAuDota.Servico.Servicos
{
    public class BaseServico<TEntity, TCreateViewModel, TUpdateViewModel, TViewModel, TRepositorio, TMapeamentoEntidade> 
        : IBaseServico<TEntity, TCreateViewModel, TUpdateViewModel, TViewModel, TRepositorio, TMapeamentoEntidade> 
        where TEntity : BaseEntity 
        where TCreateViewModel : BaseViewModel 
        where TUpdateViewModel : BaseEditarViewModel<TViewModel>
        where TViewModel: BaseViewModel
        where TRepositorio : IBaseRepositorio<TEntity>
        where TMapeamentoEntidade : IBaseMapeamentoEntidade<TEntity, TCreateViewModel, TUpdateViewModel, TViewModel>
    {
        private readonly TRepositorio _baseRepositorio;
        private readonly TMapeamentoEntidade _baseMapeamentoEntidade;

        public BaseServico(
            TRepositorio baseRepositorio,
            TMapeamentoEntidade baseMapeamentoEntidade)
        {
            _baseRepositorio = baseRepositorio;
            _baseMapeamentoEntidade = baseMapeamentoEntidade;
        }

        public virtual bool Apagar(int id) =>
            _baseRepositorio.Apagar(id);

        public TEntity Cadastrar(TCreateViewModel viewModel)
        {
            var entity = _baseMapeamentoEntidade.ConstruirCom(viewModel);

            _baseRepositorio.Cadastrar(entity);

            return entity;
        }

        public virtual bool Editar(TUpdateViewModel viewModel)
        {
            var entity = _baseRepositorio.ObterPorId(viewModel.Id);

            if (entity == null)
                return false;

            _baseMapeamentoEntidade.AtualizarCampos(entity, viewModel);

            _baseRepositorio.Editar(entity);

            return true;
        }

        public virtual bool Logon(string email, string senha)
        {
            var entity = _baseRepositorio.Logon(email, senha);

            if (entity == null)
                return false;

            return true;
        }

        public virtual TEntity? ObterPorId(int id)
        {
            var entity = _baseRepositorio.ObterPorId(id);

            return entity;
        }

        public virtual IList<TEntity> ObterTodos()
        {
            var list = _baseRepositorio.ObterTodos();

            return list;
        }

        public IList<TEntity> ObterTodosComFiltro(string pesquisa)
        {
            var list = _baseRepositorio.ObterTodosComFiltro(pesquisa);

            return list;
        }
    }
}