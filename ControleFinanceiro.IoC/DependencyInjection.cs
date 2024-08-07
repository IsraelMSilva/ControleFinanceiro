using ControleFinanceiro.Application.Interfaces;
using ControleFinanceiro.Application.Services;
using ControleFinanceiro.Domain.Repositories;
using ControleFinanceiro.Infrastructure.Repositories.Mock;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddSingleton<ITipoCategoriaRepository, TipoCategoriaMock>();
            services.AddSingleton<ITipoEntradaRepository, TipoEntradaMock>();
            services.AddSingleton<ITipoLancamentoRepository, TipoLancamentoMock>();
            services.AddSingleton<ITipoFormaPagamentoRepository, TipoFormaPagamentoMock>();
            services.AddSingleton<ITipoSaidaRepository, TipoSaidaMock>();
            services.AddSingleton<ISaidaRepository, SaidaMock>();
            services.AddSingleton<IParcelaRepository, ParcelaMock>();

            return services;
        }

        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddSingleton<ITipoCategoriaService, TipoCategoriaService>();
            services.AddSingleton<ITipoEntradaService, TipoEntradaService>();
            services.AddSingleton<ITipoLancamentoService, TipoLancamentoService>();
            services.AddSingleton<ITipoFormaPagamentoService, TipoFormaPagamentoService>();
            services.AddSingleton<ITipoSaidaService, TipoSaidaService>();
            services.AddSingleton<ISaidaService, SaidaService>();
            services.AddSingleton<IParcelaService, ParcelaService>();

            return services;
        }
    }
}
