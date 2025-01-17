﻿using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Servico.ViewModels.Protetores;

namespace Entra21.MiAuDota.Servico.MapeamentoViewModel
{
    public class ProtetorMapeamentoViewModel : IProtetorMapeamentoViewModel
    {
        public ProtetorEditarViewModel ConstruirCom(Protetor entity)
        {
            return new ProtetorEditarViewModel
            {
                Nome = entity.Nome,
                Endereco = entity.Endereco,
                Celular = entity.Celular,
                Telefone = entity.Telefone,
                Pix = entity.Pix,
                Instagram = entity.Instagram,
                Facebook = entity.Facebook,
            };
        }
    }
}