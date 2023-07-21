using Microsoft.EntityFrameworkCore;

namespace Sipay_Api_Second_Week_Assignment;

public class SimDbContext : DbContext
{
    public SimDbContext(DbContextOptions<SimDbContext> options) : base(options)
    {

    }


    // dbset
    //public DbSet<Account> Account { get; set; }
    public DbSet<Transaction> Transaction { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }



}
