using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Assets.Item;

public class ItemCraftMaterial {
    [Key]
    public long Id { get; set; }

    [Required]
    [ForeignKey(nameof(Item))]
    public int ItemId { get; set; }
    public virtual Item Item { get; set; } = null!;

    [Required]
    [Range(1, int.MaxValue)]
    public int Amount { get; set; }

    [Required]
    [ForeignKey(nameof(ItemCraft))]
    public long ItemCraftId { get; set; }
    public virtual ItemCraft ItemCraft { get; set; } = null!;
}