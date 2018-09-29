namespace WebDbGrupo01.Data
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using WebDbGrupo01.Models.MyDb;

    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Programa> Programa { get; set; }
        public DbSet<Estudiante> Estudiantes { get; set; }

    }
}
