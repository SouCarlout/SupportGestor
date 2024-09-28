using Microsoft.EntityFrameworkCore;
using SupportGestor.Models;

namespace SupportGestor.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }
        public DbSet<Atendimento> GetAtendimentos { get; set; }
    }
 
}