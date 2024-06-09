using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Assets.Item;

public class ItemCraft {
    [Key]
    public long Id { get; set; }
    
    [Required]
    [Range(1, int.MaxValue)]
    public int SequencialId { get; set; }

    [Required]
    [ForeignKey(nameof(Item))]
    public int ItemId { get; set; }
    public virtual Item Item { get; set; } = null!;

    [Required]
    [ForeignKey(nameof(Npc))]
    public int NpcId { get; set; }
    public virtual Npc Npc { get; set; } = null!;

    [Required]
    [Range(1, 100)]
    public byte SuccessRate { get; set; }

    [Required]
    public long Price { get; set; }

    [Required]
    [Range(1, int.MaxValue)]
    public int Amount { get; set; }

    public virtual ICollection<ItemCraftMaterial> ItemCraftMaterials { get; set; } = new List<ItemCraftMaterial>();
}