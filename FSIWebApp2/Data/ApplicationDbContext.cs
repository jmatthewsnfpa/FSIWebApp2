using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using FSIWebApp2.Data.Models;

namespace FSIWebApp2.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<FSIWebApp2.Data.Models.FSI> FSI { get; set; } = default!;
        public DbSet<FSIWebApp2.Data.Models.ProtectedTowns> ProtectedTowns { get; set; } = default!;
        public DbSet<FSIWebApp2.Data.Models.FileMakerReference> FileMakerReference { get; set; } = default!;
    }
}
