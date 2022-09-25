using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using SimplonAcademy.Models;

namespace SimplonAcademy.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Formation> Formations { get; set; }
        public DbSet<FormationType> FormationTypes { get; set; }
        public DbSet<InscriptionForm> InscriptionForms { get; set; }
        public DbSet<Ville> Villes { get; set; }
    }
}