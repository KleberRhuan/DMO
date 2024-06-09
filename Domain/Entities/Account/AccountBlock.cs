using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Enums.Account;
using Lombok.NET;

namespace Domain.Entities.Account;

[AllArgsConstructor]
public class AccountBlock {
    [Key] public long Id { get; set; }

    [Required]
    [EnumDataType(typeof(BlockType))]
    [Column(TypeName = "int")]
    public BlockType Type { get; set; }

    [Required]
    [StringLength(1500, ErrorMessage = "Reason length can't be more than 1500 characters.")]
    public string Reason { get; set; } = null!;
    
    [Required]
    [ForeignKey(nameof(AccountId))]
    public long AccountId { get; set; }
    public virtual Account Account { get; set; } = null!;
    
    [Required]
    [ForeignKey(nameof(CreatedBy))]
    public long CreatedBy { get; set; }
    public virtual Account CreatedByAccount { get; set; } = null!;

    [Required]
    [DataType(DataType.DateTime)]
    public DateTime StartDate { get; set; }

    [Required]
    [DataType(DataType.DateTime)]
    public DateTime EndDate { get; set; }
    
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public DateTime CreatedAt { get; private set; }
    
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTime UpdatedAt { get; private set; }
    
}