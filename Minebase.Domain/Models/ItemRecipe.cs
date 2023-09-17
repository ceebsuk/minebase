namespace Minebase.Domain.Models;

public class ItemRecipe
{
    public Guid Id { get; set; }
    
    public Guid ItemId { get; set; }

    public Guid RecipeId { get; set; }

    public int Quantity { get; set; }
}