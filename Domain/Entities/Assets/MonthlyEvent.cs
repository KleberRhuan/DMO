using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Assets;

public class MonthlyEvent {
    [Key]
    public long Id { get; set; }

    [Required]
    [Range(1, 31)]
    public int CurrentDay { get; set; }

    [Required]
    [ForeignKey(nameof(Item))]
    public int ItemId { get; set; }
    public virtual Item Item { get; set; }

    [Required]
    public int ItemCount { get; set; }
}