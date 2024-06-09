using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Assets.Item;

public class ContainerReward {
    [Key]
    public long Id { get; set; }

    [Required]
    [ForeignKey(nameof(ItemId))]
    public int ItemId { get; set; }
    public virtual Item Item { get; set; }

    [Required]
    [StringLength(100, ErrorMessage = "Name length can't be more than 100.")]
    public string ItemName { get; set; } = null!;

    [Required]
    [Range(1, int.MaxValue)]
    public int MinAmount { get; set; }

    [Required]
    [Range(1, int.MaxValue)]
    public int MaxAmount { get; set; }

    [Required]
    public decimal Chance { get; set; }

    [DefaultValue(false)]
    public bool Rare { get; set; }

    [Required]
    [ForeignKey(nameof(ContainerAssetId))]
    public long ContainerAssetId { get; set; }
    public virtual Container Container { get; set; } = null!;
}