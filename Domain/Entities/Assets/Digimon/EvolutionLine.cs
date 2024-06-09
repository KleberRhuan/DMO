using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Assets.Digimon;

public class EvolutionLine {
    [Key]
    public long Id { get; set; }

    [Required]
    [ForeignKey(nameof(Evolution))]
    public long EvolutionId { get; set; }
    public virtual Evolution Evolution { get; set; }
    
    [Required]
    [Range(1, int.MaxValue)]
    public int Type { get; set; }

    [Required]
    [Range(1, int.MaxValue)]
    public int UnlockItemSection { get; set; }

    [Required]
    [Range(1, int.MaxValue)]
    public int UnlockItemSectionAmount { get; set; }

    [Required]
    [Range(1, byte.MaxValue)]
    public byte UnlockLevel { get; set; }

    [Required]
    [Range(1, short.MaxValue)]
    public short UnlockQuestId { get; set; }

    [Required]
    [Range(1, byte.MaxValue)]
    public byte SlotLevel { get; set; }

    [Required]
    [Range(1, int.MaxValue)]
    public int RequiredAmount { get; set; }

    [Required]
    [ForeignKey(nameof(Item))]
    public int RequiredItem { get; set; }
    public virtual Item Item { get; set; }
    
    public virtual ICollection<EvolutionStage> EvolutionStages { get; set; } = new List<EvolutionStage>();
}