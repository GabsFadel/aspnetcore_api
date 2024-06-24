using Microsoft.EntityFrameworkCore;
using Web_API_Study.Data.Map;
using Web_API_Study.Models;

namespace Web_API_Study.Data
{
    public class SistemaTarefasDBContext : DbContext
    {
            public SistemaTarefasDBContext(DbContextOptions<SistemaTarefasDBContext> options)
                : base(options) 
            { 
            }

            public DbSet<UsuarioModel> Usuarios { get; set; }
            public DbSet<TarefaModel> Tarefa { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new TarefaMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}