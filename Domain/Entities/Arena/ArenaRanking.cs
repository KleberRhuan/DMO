using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Arena;

public class ArenaRanking {
    [Key]
    public Guid Id { get; private set; }

    [Required]
    [EnumDataType(typeof(ArenaType))]
    [Column(TypeName = "int")]
    public ArenaType Type { get; private set; } = null!;

    [Required]
    public DateTime StartDate { get; private set; }

    [Required]
    public DateTime EndDate { get; private set; }
    
    public virtual ICollection<ArenaCompetitor> Competitors { get; private set; } = 
        new List<ArenaCompetitor>();
    
}