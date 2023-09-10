using Microsoft.EntityFrameworkCore;
using Minebase.Domain.Models;

namespace Minebase.Data.Context;

public class MinebaseDbContext : DbContext
{
    public DbSet<Item> Items { get; set; }
    public DbSet<Recipe> Recipes { get; set; }
    
    public MinebaseDbContext(DbContextOptions<MinebaseDbContext> options) : base(options)
    {
    }
}