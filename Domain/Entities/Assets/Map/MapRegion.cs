using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Enums;

namespace Domain.Entities.Assets.Map;

public class MapRegion {
    [Key]
    public long Id { get; set; }

    [Required]
    [Range(0, byte.MaxValue)]
    public byte Index { get; set; }

    [Required]
    [Range(int.MinValue, int.MaxValue)]
    public int X { get; set; }

    [Required]
    [Range(int.MinValue, int.MaxValue)]
    public int Y { get; set; }

    [Required]
    [StringLength(100)]
    public string Name { get; set; } = null!;

    [Required]
    [ForeignKey(nameof(MapRegionListId))]
    public long MapRegionListId { get; set; }
    public virtual MapRegionList MapRegionList { get; set; } = null!;
}