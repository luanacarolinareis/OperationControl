using Microsoft.EntityFrameworkCore;
namespace OperationControl.Models;


public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Tools> ferramentas { get; set; }
    public DbSet<Desk> desks { get; set; }

}
