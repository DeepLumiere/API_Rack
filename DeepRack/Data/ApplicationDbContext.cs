using DeepRack.Models;
using Microsoft.EntityFrameworkCore;

namespace DeepRack.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    public DbSet<Appointment> Appointments { get; set; }
    public DbSet<Notes> Notes { get; set; }
    public DbSet<Contacts> Contacts { get; set; }
    
}