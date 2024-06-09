using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.Assets.Digimon;

public class CloneValue {
    [Key]
    public long Id { get; set; }

    [Required]
    [Range(1, int.MaxValue)]
    public int Type { get; set; }

    [Required]
    [Range(1, byte.MaxValue)]
    public byte MinLevel { get; set; }
    
    [Required]
    [Range(1, byte.MaxValue)]
    public byte MaxLevel { get; set; }

    [Required]
    [Range(0, int.MaxValue)]
    public int MinValue { get; set; }

    [Required]
    [Range(0, int.MaxValue)]
    public int MaxValue { get; set; }
    
}