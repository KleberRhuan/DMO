using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.Assets.Digimon;

public class Clone {
    [Key]
    public long Id { get; set; }

    [Required]
    [Range(1, int.MaxValue)]
    public int ItemSection { get; set; }

    [Required]
    [Range(1, byte.MaxValue)]
    public byte MinLevel { get; set; }

    [Required]
    [Range(1, byte.MaxValue)]
    public byte MaxLevel { get; set; }

    [Required]
    [Range(0, long.MaxValue)]
    public long Bits { get; set; }
    
}