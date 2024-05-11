using DoctorOnline.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DoctorOnline.DAL
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Test> Tests { get; set; }
    }
}
