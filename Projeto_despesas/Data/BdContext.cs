using Microsoft.EntityFrameworkCore;
using api_Despesas.models;
namespace api_Despesas.Data
{
    public class BdContext : DbContext
    {
        public BdContext(DbContextOptions<BdContext> options) : base(options)
        {
        }
        public DbSet<Despesas> Despesas { get; set;}
    }
}