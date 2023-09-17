using Microsoft.EntityFrameworkCore;
using Minebase.Data.Configurations;
using Minebase.Domain.Models;

namespace Minebase.Data.Context;

/// <summary>
/// A class representing the database context for the Minebase application.
/// </summary>
public class MinebaseDbContext : DbContext
{
    /// <summary>
    /// The collection of items in the database.
    /// </summary>
    public DbSet<Item> Items { get; set; }
    
    /// <summary>
    /// The collection of recipes in the database.
    /// </summary>
    public DbSet<Recipe> Recipes { get; set; }
    
    public MinebaseDbContext(DbContextOptions<MinebaseDbContext> options) : base(options)
    {
    }
    
    // Override the OnModelCreating method to configure entity relations.
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfiguration(new ItemConfiguration());
        modelBuilder.ApplyConfiguration(new RecipeConfiguration());
    }
}