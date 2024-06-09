using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Enums;

public class MapRegionList {
    [Key]
    public long Id { get; set; }

    [Required]
    [ForeignKey(nameof(MapId))]
    public int MapId { get; set; }
    public virtual Map Map { get; set; } = null!;

    [Required]
    public string Name { get; set; } = null!;

    public virtual ICollection<MapRegion> MapRegions { get; set; } = new List<MapRegion>();
}