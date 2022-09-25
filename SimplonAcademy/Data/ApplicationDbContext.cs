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

        public DbSet<Formation> formations { get; set; }
        public DbSet<FormationType> formationTypes { get; set; }
        public DbSet<InscriptionForm> inscriptionForms { get; set; }
    }
}