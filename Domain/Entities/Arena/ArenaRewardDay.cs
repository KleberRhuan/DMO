using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Enums.Arena;

namespace Domain.Entities.Arena;

public class ArenaRewardDay {
    [Key]
    public int Id { get; set; }
    
    [Required]
    [EnumDataType(typeof(WeekDays))]
    [Column(TypeName = "int")]
    public WeekDays WeekDay { get; set; }
    
    public ICollection<ArenaItemReward> ItemRewards { get; set; } = new List<ArenaItemReward>();
}