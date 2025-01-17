﻿using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Repositorio.Repositorios;
using Entra21.MiAuDota.Servico.Autenticacao;
using Entra21.MiAuDota.Servico.MapeamentoEntidades;
using Entra21.MiAuDota.Servico.MapeamentoViewModel;
using Entra21.MiAuDota.Servico.ViewModels;

namespace Entra21.MiAuDota.Servico.Servicos
{
    public class BaseServico<TEntity, TBaseModel, TCreateViewModel, TUpdateViewModel, TUpdateStatusViewModel, TUpdateSenhaViewModel, TViewModel, TRepositorio, TMapeamentoEntidade, TMapeamentoViewModel>
        : IBaseServico<TEntity, TBaseModel, TCreateViewModel, TUpdateViewModel, TUpdateStatusViewModel, TUpdateSenhaViewModel, TViewModel, TRepositorio, TMapeamentoEntidade, TMapeamentoViewModel>
        where TEntity : BaseEntity
        where TBaseModel : UsuarioBase
        where TCreateViewModel : BaseViewModel
        where TUpdateViewModel : BaseEditarViewModel<TViewModel>
        where TUpdateStatusViewModel : BaseEditarViewModel<TViewModel>
        where TUpdateSenhaViewModel : BaseEditarViewModel<TViewModel>
        where TViewModel : BaseViewModel
        where TRepositorio : IBaseRepositorio<TEntity>
        where TMapeamentoEntidade : IBaseMapeamentoEntidade<TEntity, TCreateViewModel, TUpdateViewModel, TUpdateStatusViewModel, TUpdateSenhaViewModel, TViewModel>
        where TMapeamentoViewModel : IBaseMapeamentoViewModel<TEntity, TUpdateViewModel, TUpdateStatusViewModel, TUpdateSenhaViewModel, TViewModel>
    {
        protected readonly TRepositorio _baseRepositorio;
        protected readonly TMapeamentoEntidade _baseMapeamentoEntidade;
        private readonly TMapeamentoViewModel _mapeamentoViewModel;
        private readonly ISessionManager _sessionManager;

        public BaseServico(
            TRepositorio baseRepositorio,
            TMapeamentoEntidade baseMapeamentoEntidade,
            TMapeamentoViewModel mapeamentoViewModel,
            ISessionManager sessionManager)
        {
            _baseRepositorio = baseRepositorio;
            _baseMapeamentoEntidade = baseMapeamentoEntidade;
            _mapeamentoViewModel = mapeamentoViewModel;
            _sessionManager = sessionManager;
        }

        public virtual bool Apagar(int id) =>
            _baseRepositorio.Apagar(id);

        public virtual TEntity Cadastrar(TCreateViewModel viewModel, string? caminho)
        {
            var entity = _baseMapeamentoEntidade.ConstruirCom(viewModel, caminho);

            _baseRepositorio.Cadastrar(entity);

            return entity;
        }

        public virtual bool EditarCampos(TUpdateViewModel viewModel)
        {
            var entity = _baseRepositorio.ObterPorId(viewModel.Id);

            if (entity == null)
                return false;

            _baseMapeamentoEntidade.AtualizarCampos(entity, viewModel);

            _baseRepositorio.EditarCampos(entity);

            return true;
        }

        public virtual bool EditarSenha(TUpdateSenhaViewModel viewModel)
        {
            var baseModel = _sessionManager.GetUser<TBaseModel>();
            var entity = _baseRepositorio.ObterPorId(baseModel.Id);

            if (entity == null)
                return false;

            _baseMapeamentoEntidade.AtualizarSenha(entity, viewModel);

            _baseRepositorio.EditarSenha(entity);

            return true;
        }

        public virtual bool EditarStatus(TUpdateStatusViewModel viewModel)
        {
            var baseModel = _sessionManager.GetUser<TBaseModel>();
            var entity = _baseRepositorio.ObterPorId(baseModel.Id);

            if (entity == null)
                return false;

            _baseMapeamentoEntidade.AtualizarStatus(entity, viewModel);

            _baseRepositorio.EditarStatus(entity);

            return true;
        }

        public virtual TUpdateViewModel? ObterPorId(int id)
        {
            var entity = _baseRepositorio.ObterPorId(id);

            if (entity == null)
                return null;

            var viewModel = _mapeamentoViewModel.ConstruirCom(entity);

            return viewModel;
        }

        public virtual IList<TEntity> ObterTodos()
        {
            var list = _baseRepositorio.ObterTodos();

            return list;
        }

        public virtual IList<TEntity> ObterTodosComFiltro()
        {
            var list = _baseRepositorio.ObterTodosComFiltro();

            return list;
        }
    }
}