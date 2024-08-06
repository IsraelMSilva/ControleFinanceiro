using ControleFinanceiro.Application.Interfaces;
using ControleFinanceiro.Application.Services;
using ControleFinanceiro.Domain.Repositories;
using ControleFinanceiro.Infrastructure.Repositories.Mock;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
 builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<ITipoCategoriaService, TipoCategoriaService>();
builder.Services.AddSingleton<ITipoCategoriaRepository, TipoCategoriaMock>();
builder.Services.AddSingleton<ITipoLancamentoRepository, TipoLancamentoMock>();
builder.Services.AddSingleton<ITipoEntradaRepository, TipoEntradaMock>();
builder.Services.AddSingleton<ITipoFormaPagamentoRepository, TipoFormaPagamentoMock>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
