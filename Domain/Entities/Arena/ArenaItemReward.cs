using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Arena;

public class ArenaItemReward {
    [Key]
    public long Id { get; set; }

    [Required]
    [ForeignKey(nameof(ItemId))]
    public long ItemId { get; set; }
    public virtual Item Item { get; set; }

    [Required]
    public int Amount { get; set; }

    [Required]
    public byte RequiredCoins { get; set; }

    [Required]
    [ForeignKey(nameof(RewardId))]
    public long RewardId { get; set; }
    public virtual ArenaRewardDay Reward { get; set; }
    
    [Required]
    [ForeignKey(nameof(AccountId))]
    public long AccountId { get; set; }
    public virtual Account Account { get; set; }
    
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public DateTime CreatedAt { get; set; }
    
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTime UpdatedAt { get; set; }


}