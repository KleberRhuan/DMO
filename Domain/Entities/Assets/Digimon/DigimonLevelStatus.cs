using System.ComponentModel.DataAnnotations;
using Domain.Interfaces;

namespace Domain.Entities.Assets.Digimon;

public class DigimonLevelStatus : Status {

    [Key]
    public long Id { get; set; }
    
    [Required] [Range(1, int.MaxValue)] public int Type { get; set; }

    [Required] [Range(1, byte.MaxValue)] public byte Level { get; set; }
    
    [Required] [Range(0, int.MaxValue)] public long ExpValue { get; set; }
    
    [Required] [Range(0, int.MaxValue)] public long StatusId { get; set; }
    
    [Required] [Range(0, int.MaxValue)] public long ScaleType { get; set; }
    
    
}