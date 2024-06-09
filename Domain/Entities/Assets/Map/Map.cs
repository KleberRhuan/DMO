using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.Assets.Map;

public class Map {
    [Key]
    public long Id { get; set; }

    [Required]
    [Range(1, int.MaxValue)]
    public int MapId { get; set; }

    [Required]
    public string Name { get; set; } = null!;

    [Required]
    [Range(1, byte.MaxValue)]
    public byte RegionIndex { get; set; }
}