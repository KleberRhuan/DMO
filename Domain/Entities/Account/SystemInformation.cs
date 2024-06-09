using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Lombok.NET;

namespace Domain.Entities.Account;

[AllArgsConstructor]
public class SystemInformation {
    [Key] public long Id { get; private set; }

    [Required]
    [StringLength(100, ErrorMessage = "CPU name cannot be longer than 100 characters.")]
    public string Cpu { get; private set; } = null!;

    [Required]
    [StringLength(100, ErrorMessage = "GPU name cannot be longer than 100 characters.")]
    public string Gpu { get; private set; } = null!;

    [Required]
    [StringLength(255, ErrorMessage = "IP address cannot be longer than 255 characters.")]
    public string Ip { get; private set; } = null!;

    [Required] 
    [ForeignKey(nameof(AccountId))]
    public long AccountId { get; private set; }
    public virtual Account Account { get; private set; } = null!;

    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public DateTime CreatedAt { get; private set; }

    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTime UpdatedAt { get; private set; }

}