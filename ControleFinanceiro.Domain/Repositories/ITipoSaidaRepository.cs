﻿using ControleFinanceiro.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Domain.Repositories
{
    public interface ITipoSaidaRepository : IRepositoryCrud<TipoSaida>
    {
		Task<IEnumerable<TipoSaida>> ObterTipoSaidaPorDescricao(string descricao);
	}
}
