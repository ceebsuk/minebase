using Microsoft.EntityFrameworkCore;
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
}