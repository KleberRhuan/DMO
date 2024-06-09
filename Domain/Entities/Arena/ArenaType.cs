using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Arena;

public class ArenaType {
    [Key]
    public int Id { get; private set; }
        
    [Required]
    public string Name { get; private set; } = null!;
        
    public virtual ICollection<ArenaRanking> ArenaRankings { get; private set; } = new List<ArenaRanking>();
        
    [Required]
    [ForeignKey(nameof(CreatedById))]
    public long CreatedById { get; private set; }
    public virtual Account.Account CreatedBy { get; private set; } = null!;
        
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public DateTime CreatedAt { get; private set; }
        
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTime UpdatedAt { get; private set; }

}