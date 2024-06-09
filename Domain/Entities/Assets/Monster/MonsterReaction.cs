using System.ComponentModel.DataAnnotations;
using Domain.Enums.Digimon;
using Domain.Interfaces;
using Attribute = System.Attribute;

namespace Domain.Entities.Assets.Monster;

public class MonsterReaction : StatusAbstract {
    
    [Key]
    public long Id { get; set; }

    [Required]
    [Range(1, int.MaxValue)]
    public int Type { get; set; }

    [Required]
    [Range(1, int.MaxValue)]
    public int Model { get; set; }

    [Required]
    public string Name { get; set; } = null!;

    [Required]
    [Range(1, int.MaxValue)]
    public byte Level { get; set; }
    
    //TODO: Determine The ViewRange and Create a new Enum
    [Required]
    [Range(0, int.MaxValue)]
    public int ViewRange { get; set; }
    
    //TODO: Determine The HuntRange and Create a new Enum
    [Required]
    [Range(0, int.MaxValue)]
    public int HuntRange { get; set; }
    
    [Required]
    [EnumDataType(typeof(Enums.Digimon.MonsterReaction))]
    public Enums.Digimon.MonsterReaction ReactionType { get; set; }

    [Required]
    [EnumDataType(typeof(Enums.Digimon.Attribute))]
    public Attribute Attribute { get; set; }

    [Required]
    [EnumDataType(typeof(Enums.Digimon.Element))]
    public Element Element { get; set; }

    [Required]
    [EnumDataType(typeof(Enums.Digimon.Family))]
    public Family Family1 { get; set; }

    [Required]
    [EnumDataType(typeof(Enums.Digimon.Family))]
    public Family Family2 { get; set; }

    [Required]
    [EnumDataType(typeof(Enums.Digimon.Family))]
    public Family Family3 { get; set; }
    
}