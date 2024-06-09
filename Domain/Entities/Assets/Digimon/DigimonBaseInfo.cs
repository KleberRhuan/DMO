using System.ComponentModel.DataAnnotations;
using Domain.Enums.Digimon;
using Attribute = System.Attribute;

namespace Domain.Entities.Assets.Digimon;

public class DigimonBaseInfo {
    
    [Key]
    public long Id { get; set; }

    [Required] [Range(1, int.MaxValue)] public int Model { get; set; }

    [Required] [StringLength(100)] public string Name { get; set; } = null!;

    [Required] [Range(1, byte.MaxValue)] public byte Level { get; set; }

    [Required] [Range(0, byte.MaxValue)] public byte ScaleType { get; set; }

    [Required]
    [EnumDataType(typeof(Attribute))]
    public Attribute Attribute { get; set;}

    [Required]
    [EnumDataType(typeof(Element))]
    public Element Element { get; set; }

    [Required] [Range(0, int.MaxValue)] public Family Family1 { get; set; }

    [Required] [Range(0, int.MaxValue)] public Family Family2 { get; set; }

    [Required] [Range(0, int.MaxValue)] public Family Family3 { get; set; }

    [Required] 
    [EnumDataType(typeof(EvolutionType))]
    public EvolutionType EvolutionType { get; set; }
}