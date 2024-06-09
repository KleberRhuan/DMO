using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Assets.Digimon;

public class ExtraEvolution {
    [Key]
    public long Id { get; set; }

    [Required]
    [Range(1, int.MaxValue)]
    public int DigimonId { get; set; }

    [Required]
    [Range(1, byte.MaxValue)]
    public byte RequiredLevel { get; set; }

    [Required]
    public long Price { get; set; }

    [Required]
    [ForeignKey(nameof(ExtraEvolutionInformation))]
    public long ExtraInfoId { get; set; }
    public virtual ExtraEvolutionInformation ExtraInfo { get; set; } = null!;

    public virtual ICollection<ExtraEvolutionMaterial> ExtraEvolutionMaterials { get; set; } = new List<ExtraEvolutionMaterial>();

    public virtual ICollection<ExtraEvolutionRequired> ExtraEvolutionRequireds { get; set; } = new List<ExtraEvolutionRequired>();


}