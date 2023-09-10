using Microsoft.EntityFrameworkCore;

namespace Minebase.Data.Context;

public class MinebaseDbContext : DbContext
{
    public MinebaseDbContext(DbContextOptions<MinebaseDbContext> options) : base(options)
    {
    }
}