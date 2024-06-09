using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Assets.Accessory;

public class AccessoryStatusType {
    [Key]
    public int Id { get; private set; }
    
    [Required]
    public string Name { get; private set; } = null!;
    
    public virtual ICollection<AccessoryRollStatus> Accessories { get; private set; } = 
        new List<AccessoryRollStatus>();
    
    [Required]
    [ForeignKey(nameof(CreatedById))]
    public long CreatedById { get; private set; }
    public virtual Account.Account CreatedBy { get; private set; } = null!;
    
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public DateTime CreatedAt { get; private set; }
    
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTime UpdatedAt { get; private set; }
}