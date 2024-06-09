using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Arena;

public class ArenaCompetitor {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; private set; }

    [Required]
    [ForeignKey(nameof(TamerId))]
    public long TamerId { get; private set; }
    public virtual Tamer Tamer { get; private set; }

    [Required]
    [Range(0, int.MaxValue, ErrorMessage = "Points must be a non-negative integer.")]
    public int Points { get; private set; }

    [Required]
    [Range(1, byte.MaxValue, ErrorMessage = "Position must be between 1 and 255.")]
    public byte Position { get; private set; }

    [DefaultValue(true)]
    public bool New { get; private set; }

    [Required]
    [ForeignKey(nameof(RankingId))]
    public Guid RankingId { get; private set; }
    public virtual long Ranking { get; private set; }
    
    
    public DateTime InsertDate { get; private set; }
    
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTime UpdatedAt { get; private set; }
}