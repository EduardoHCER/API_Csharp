using api_Despesas.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddDbContext<BdContext>(options => options.UseSqlite("Data Source=Despesas.db"));

var app = builder.Build();

app.UseHttpsRedirection();
app.MapControllers();

app.Run();