using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Enums.Character;
using Domain.Interfaces;

namespace Domain.Entities.Assets.Character;

public class CharacterBaseStatus : Status {
    [Key]
    public long Id { get; set; }
    
    [Required]
    [EnumDataType(typeof(CharacterType))]
    [Column(TypeName = "int")]
    public CharacterType Type { get; set; }

}