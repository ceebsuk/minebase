using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Minebase.Domain.Models;

namespace Minebase.Data.Configurations;

public class RecipeConfiguration : IEntityTypeConfiguration<Recipe>
{
    public void Configure(EntityTypeBuilder<Recipe> builder)
    {
        // Configure the ont-to-one relation between the recipe and the product item.
        builder.HasOne(r => r.Product);
    }
}