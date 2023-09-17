using System.ComponentModel.DataAnnotations.Schema;

namespace Minebase.Domain.Models;

/// <summary>
/// A class representing an item.
/// </summary>
public class Item : Entity
{
    /// <summary>
    /// The name of the item.
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    /// The maximum stack size of the item.
    /// </summary>
    public int StackSize { get; set; }
    
    /// <summary>
    /// The unique string identifier of the item.
    /// </summary>
    public string Tag { get; set; }

    /// <summary>
    /// The collection of recipes this item is used in.
    /// </summary>
    public List<Recipe> Recipes { get; } = new();
    

    public List<ItemRecipe> ItemRecipes { get; } = new();
}