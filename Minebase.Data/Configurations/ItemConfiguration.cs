using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Minebase.Domain.Models;

namespace Minebase.Data.Configurations;

public class ItemConfiguration : IEntityTypeConfiguration<Item>
{
    public void Configure(EntityTypeBuilder<Item> builder)
    {
        // Configure the many-to-many relationship between the item and the recipe.
        builder.HasMany(i => i.Recipes)
            .WithMany(r => r.Ingredients)
            .UsingEntity<ItemRecipe>();
    }
}