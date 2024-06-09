using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Lombok.NET;

namespace Domain.Entities.Account;

[AllArgsConstructor]
public class Permission {
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string Name { get; set; } = null!;

    public virtual ICollection<AccountPermission> AccountPermissions { get; set; } = 
        new List<AccountPermission>();

    [Required]
    [ForeignKey(nameof(CreatedBy))]
    public long CreatedById { get; set; }
    public virtual Account CreatedBy { get; private set; } = null!;

    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public DateTime CreatedAt { get; private set; }

    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTime UpdatedAt { get; private set; }
}