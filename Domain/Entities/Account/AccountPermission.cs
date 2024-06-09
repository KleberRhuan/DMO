using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Lombok.NET;

namespace Domain.Entities.Account;

[AllArgsConstructor]
public class AccountPermission {
    [Key]
    public int Id { get; set; }

    [Required]
    [ForeignKey(nameof(Account))]
    public long AccountId { get; set; }
    public virtual Account Account { get; set; } = null!;

    [Required]
    [ForeignKey(nameof(CreatedBy))]
    public long CreatedById { get; set; }
    public virtual Account CreatedBy { get; set; } = null!;

    [Required]
    [ForeignKey(nameof(Permission))]
    public int PermissionId { get; set; }
    public virtual Permission Permission { get; set; } = null!;

    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public DateTime CreatedAt { get; private set; }
    
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTime UpdatedAt { get; private set; }
    
    
}