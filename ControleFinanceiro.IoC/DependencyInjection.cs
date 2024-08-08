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
            services.AddSingleton<IEntradaRepository, EntradaMock>();
            
            services.AddSingleton<IParcelaRepository, ParcelaMock>();
            services.AddSingleton<ISaidaRepository, SaidaMock>();
            services.AddSingleton<ITipoCategoriaRepository, TipoCategoriaMock>();
            services.AddSingleton<ITipoEntradaRepository, TipoEntradaMock>();
            services.AddSingleton<ITipoFormaPagamentoRepository, TipoFormaPagamentoMock>();
            services.AddSingleton<ITipoLancamentoRepository, TipoLancamentoMock>();
            services.AddSingleton<ITipoSaidaRepository, TipoSaidaMock>();
            services.AddSingleton<IUsuarioRepository, UsuarioMock>(); // IMPLEMENTAR LÓGICA NA MOCK USUÁRIO -- TODO

            return services;
        }

        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddSingleton<IEntradaService, EntradaService>();
            //LANÇAMENTO AQUI
            services.AddSingleton<IParcelaService, ParcelaService>();
            services.AddSingleton<ISaidaService, SaidaService>();
            services.AddSingleton<ITipoCategoriaService, TipoCategoriaService>();
            services.AddSingleton<ITipoEntradaService, TipoEntradaService>();
            services.AddSingleton<ITipoFormaPagamentoService, TipoFormaPagamentoService>();
            services.AddSingleton<ITipoLancamentoService, TipoLancamentoService>();
            services.AddSingleton<ITipoSaidaService, TipoSaidaService>();
            services.AddSingleton<IUsuarioService, UsuarioService>();

            return services;
        }
    }
}
