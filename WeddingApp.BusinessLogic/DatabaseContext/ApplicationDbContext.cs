using Microsoft.EntityFrameworkCore;
using WeddingApp.BusinessLogic.Entity;
namespace WeddingApp.BusinessLogic.DatabaseContext;

public class ApplicationDbContext : DbContext 
{
    public DbSet<Event> Events { get; set; }
    public DbSet<EventItem> EventItems { get; set; }
    public DbSet<Item> Items { get; set; }
    public DbSet<ItemType> ItemTypes { get; set; }
    
    public ApplicationDbContext() 
    {   
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{
    if (!optionsBuilder.IsConfigured)
    {
        var connectionString = "Data Source=Database/WeddingApp.db";
        optionsBuilder.UseSqlite(connectionString);
    }
}
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<EventItem>().HasKey(x => new { x.EventId, x.ItemId });

        modelBuilder.Entity<EventItem>().HasOne(x => x.Event)
        .WithMany(x => x.EventItems)
        .HasForeignKey(x => x.EventId);

        modelBuilder.Entity<EventItem>().HasOne(x => x.Item)
        .WithMany(x => x.EventItems)
        .HasForeignKey(x => x.ItemId);
    }
}
