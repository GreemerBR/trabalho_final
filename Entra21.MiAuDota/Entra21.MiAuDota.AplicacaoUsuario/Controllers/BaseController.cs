﻿using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Repositorio.Repositorios;
using Entra21.MiAuDota.Servico.MapeamentoEntidades;
using Entra21.MiAuDota.Servico.Servicos;
using Entra21.MiAuDota.Servico.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Entra21.MiAuDota.AplicacaoUsuario.Controllers
{    
    public class BaseController<TEntity, TServico, TCreateViewModel, TUpdateViewModel, TViewModel, TRepositorio, TMapeamentoEntidade> : Controller
        where TEntity : BaseEntity
        where TViewModel : BaseViewModel
        where TCreateViewModel : BaseViewModel, new()
        where TUpdateViewModel : BaseEditarViewModel<TViewModel>, new()
        where TRepositorio : IBaseRepositorio<TEntity>
        where TMapeamentoEntidade : IBaseMapeamentoEntidade<TEntity, TCreateViewModel, TUpdateViewModel, TViewModel>
        where TServico : IBaseServico<TEntity, TCreateViewModel, TUpdateViewModel, TViewModel, TRepositorio, TMapeamentoEntidade>
    {
        private readonly TServico _servico;

        public BaseController(TServico servico)
        {
            _servico = servico;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("obterTodosComFiltro")]
        public IActionResult ObterTodosComFiltro([FromQuery] string pesquisa)
        {
            var entities = _servico.ObterTodosComFiltro(pesquisa);

            return Ok(entities);
        }

        [HttpGet("obterTodos")]
        public IActionResult ObterTodos()
        {
            var entities = _servico.ObterTodos();

            return Ok(entities);
        }

        [HttpGet("cadastrar")]
        public IActionResult Cadastrar()
        {
            return View(new TCreateViewModel());
        }

        [HttpPost("cadastrar")]
        public IActionResult Cadastrar([FromForm] TCreateViewModel creatViewModel)
        {
            if (!ModelState.IsValid)
                return UnprocessableEntity(ModelState);

            var entity = _servico.Cadastrar(creatViewModel);

            return RedirectToAction("Cadastrar");
        }

        [HttpGet("obterPorId")]
        public IActionResult ObterPorId([FromQuery] int id)
        {
            var entity = _servico.ObterPorId(id);

            if (entity == null)
                return NotFound();

            return Ok(entity);
        }

        [HttpGet("editar")]
        public IActionResult Editar()
        {
            return View(new TUpdateViewModel());
        }

        [HttpPost("editar")]
        public IActionResult Editar([FromBody] TUpdateViewModel updateViewModel)
        {
            var alterou = _servico.Editar(updateViewModel);

            if (!alterou)
                return NotFound();

            return Ok();
        }

        [HttpGet("apagar")]
        public IActionResult Apagar([FromQuery] int id)
        {
            var apagou = _servico.Apagar(id);

            if (!apagou)
                return NotFound();

            return Ok();
        }
    }
}