using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Assets.Digimon;

public class ExtraEvolutionNpc {
    [Key]
    public long Id { get; set; }

    [Required]
    [ForeignKey(nameof(Npc))]
    public int NpcId { get; set; }
    public virtual Npc Npc { get; set; } = null!;

    public virtual ICollection<ExtraEvolutionInformation> ExtraEvolutionInformations { get; set; } = new List<ExtraEvolutionInformation>();
}