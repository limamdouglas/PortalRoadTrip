using Microsoft.EntityFrameworkCore;
using portal_roadtrip.Application.Interfaces;
using portal_roadtrip.Application.Services;
using portal_roadtrip.Persistence.Context;
using portal_roadtrip.Persistence.Interfaces;
using portal_roadtrip.Persistence.Repositorys;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<DataContext>(
        context => context.UseSqlite(builder.Configuration.GetConnectionString("Default"))
    );

builder.Services.AddControllers();

builder.Services.AddScoped<IUsuariosService, UsuariosService>();
builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();
builder.Services.AddScoped<ICargoService, CargoService>();
builder.Services.AddScoped<ICargoRepository, CargoRepository>();
builder.Services.AddScoped<IConexaoUsuarioService, ConexaoUsuarioService>();
builder.Services.AddScoped<IConexaoUsuarioRepository, ConexaoUsuarioRepository>();
builder.Services.AddScoped<IEventoService, EventoService>();
builder.Services.AddScoped<IEventoRepository, EventoRepository>();
builder.Services.AddScoped<IEventoFuncionarioService, EventoFuncionarioService>();
builder.Services.AddScoped<IEventoFuncionarioRepository, EventoFuncionarioRepository>();
builder.Services.AddScoped<IEventoPontoEmbarqueService, EventoPontoEmbarqueService>();
builder.Services.AddScoped<IEventoPontoEmbarqueRepository, EventoPontoEmbarqueRepository>();
builder.Services.AddScoped<IFuncionarioService, FuncionarioService>();
builder.Services.AddScoped<IFuncionarioRepository, FuncionarioRepository>();
builder.Services.AddScoped<IPontoEmbarqueService, PontoEmbarqueService>();
builder.Services.AddScoped<IPontoEmbarqueRepository, PontoEmbarqueRepository>();
builder.Services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
builder.Services.AddScoped<IEstadosBrService, EstadosBrService>();
builder.Services.AddScoped<ICategoriaEventoService, CategoriaEventoService>();
builder.Services.AddScoped<ICategoriaEventoRepository, CategoriaEventoRepository>();

builder.Services.AddCors();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors(cors => cors.AllowAnyHeader()
                        .AllowAnyMethod()
                        .AllowAnyOrigin()
);

app.MapControllers();

app.Run();
