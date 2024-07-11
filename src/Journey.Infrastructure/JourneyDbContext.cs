using Journey.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace Journey.Infrastructure;

public class JourneyDbContext : DbContext
{
    public DbSet<Trip> Trips { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //TODO: Adicionar o local do banco de dados antes de JourneyDatabase.db
        optionsBuilder.UseSqlite("Data Source=C:\\Users\\lucas\\OneDrive\\Documentos\\Workspace\\NLW Journey\\Journey\\src\\Journey.Infrastructure\\JourneyDatabase.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Activity>().ToTable("Activities");
    }
}

