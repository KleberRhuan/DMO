using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Assets.Item;

public class Container {
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
    [Range(0, int.MaxValue)]
    public int RewardAmount { get; set; }

    public virtual ICollection<ContainerReward> ContainerRewards { get; set; } = new List<ContainerReward>();
}