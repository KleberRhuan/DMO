using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Arena;

public class ArenaCurrentStagePoint {
    [Key]
    public long Id { get; set; }
    
    [Required]
    [ForeignKey(nameof(ItemId))]
    public long ItemId { get; set; }
    public virtual Item Item { get; set; }

    [Required]
    [Range(0, int.MaxValue, ErrorMessage = "Amount must be a non-negative integer.")]
    public int Amount { get; set; }

    [Required]
    [Range(1, byte.MaxValue, ErrorMessage = "Position must be between 1 and 255.")]
    public byte CurrentStage { get; set; }

    [Required]
    [ForeignKey(nameof(CharacterId))]
    public long CharacterId { get; set; }
    public virtual Tamer Tamer { get; set; }
    
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public DateTime CreatedAt { get; set; }
    
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTime UpdatedAt { get; set; }

}