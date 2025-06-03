using Microsoft.EntityFrameworkCore;
using DeepRack.Models;

namespace DeepRack.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Notes> Notes { get; set; } // <-- This is needed

    }
}