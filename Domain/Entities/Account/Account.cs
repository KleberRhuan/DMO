using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Enums.Account;
using Lombok.NET;

namespace Domain.Entities.Account;

[AllArgsConstructor]
public class Account {
    [Key]
    public long Id { get; private set; }
    
    [Required]
    [StringLength(255, MinimumLength = 3)]
    public string Username { get; private set; } = null!;

    [Required]
    [StringLength(100, MinimumLength = 6)]
    public string Password { get; private set; } = null!;

    [StringLength(6)]
    public string? SecondaryPassword { get; private set; }
    
    [Required]
    [EmailAddress]
    public string Email { get; private set; }= null!;
    
    [Required]
    [EnumDataType(typeof(AccessLevel))]
    [Column(TypeName = "int")]
    public AccessLevel AccessLevel { get; private set; }
    
    public DateTime? LastConnection { get; private set; }
    public DateTime? MembershipExpirationDate { get; private set; }
    
    [Range(0, int.MaxValue)]
    public int Premium { get; private set; }
    
    [Range(0, int.MaxValue)]
    public int Silk { get; private set; }
    
    [Range(0, int.MaxValue)]
    [ForeignKey(nameof(LastPlayedServerId))]
    public long LastPlayedServerId { get; private set; }
    public virtual Server LastPlayedServer { get; private set; } = null!;

    [Range(0, int.MaxValue)]
    [ForeignKey(nameof(LastPlayedCharacterId))]
    public long LastPlayedCharacterId { get; private set; }
    public virtual Character LastPlayedCharacter { get; private set; } = null!;
    
    [DefaultValue(false)]
    public bool ReceiveWelcome { get; private set; }
    
    [StringLength(100)]
    public string? DiscordId { get; private set; }
    
    public virtual ICollection<ItemList> ItemLists { get; private set; } = new List<ItemList>();
    public virtual SystemInformation? SystemInformation { get; private set; }
    public virtual ICollection<AccountPermission> AccountPermissions { get; private set; } 
        = new List<AccountPermission>();
    
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public DateTime CreatedAt { get; private set; }
    
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTime UpdatedAt { get; private set; }
    
}