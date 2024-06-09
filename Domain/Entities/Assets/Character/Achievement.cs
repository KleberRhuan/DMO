using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Assets.Character;

public class Achievement {
    [Key]
    public long Id { get; set; }

    [Required]
    [ForeignKey(nameof(QuestId))]
    public long QuestId { get; set; }
    public virtual Quest Quest { get; set; }

    [Required]
    [Range(0, byte.MaxValue)]
    public byte Type { get; set; }

    [Required]
    [ForeignKey(nameof(BuffId))]
    public long BuffId { get; set; }
    public virtual Buff Buff { get; set; }
    
}