using System.ComponentModel.DataAnnotations.Schema;

namespace Minebase.Domain.Models;

public class Recipe : Entity
{
    /// <summary>
    /// The Id of the item this recipe produces.
    /// </summary>
    public Guid ProductId { get; set; }
    
    /// <summary>
    /// The item this recipe produces.
    /// </summary>
    public Item Product { get; set; }
    
    /// <summary>
    /// A collection of ingredients required to produce the item.
    /// </summary>
    public List<Item> Ingredients { get; } = new();
    
    
    public List<ItemRecipe> ItemRecipes { get; } = new();
}