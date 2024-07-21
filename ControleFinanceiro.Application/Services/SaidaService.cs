using ControleFinanceiro.Application.Interfaces;
using ControleFinanceiro.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ControleFinanceiro.Application.DTOs.SaidaDTO;

namespace ControleFinanceiro.Application.Services
{
	public class SaidaService : ISaidaService
	{
		private readonly ISaidaRepository _saidaRepository;
		public SaidaService(ISaidaRepository saidaRepository)
		{
			_saidaRepository = saidaRepository;
		}
	}
}
