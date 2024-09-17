using Exo.WebApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;

namespace Exo.WebApi.Contexts
{
    public class ExoContext : DbContext
    {
        public ExoContext()
        {
        }

        public ExoContext(DbContextOptions<ExoContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Exemplo de string de conexão:
                // Altere "YourPassword123!" pela sua senha correta
                optionsBuilder.UseSqlServer("Server=localhost;Database=ExoApi;User ID=sa;Password=YourPassword123!;Trusted_Connection=False;TrustServerCertificate=True;");
            }
        }

        public DbSet<Projeto> Projetos { get; set; }
    }
}
