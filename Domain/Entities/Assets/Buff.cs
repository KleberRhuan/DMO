using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.Assets;

public class Buff {
    [Key]
    public long Id { get; set; }
    
    [Required]
    public string Name { get; set; }
    
    [DefaultValue(0)]
    [Range(0, int.MaxValue, ErrorMessage = "DigimonSkillCode must be between 0 and int.MaxValue.")]
    public int DigimonSkillCode { get; set; }
    
    [DefaultValue(0)]
    [Range(0, int.MaxValue, ErrorMessage = "SkillCode must be between 0 and int.MaxValue.")]
    public int SkillCode { get; set; }
    
    [DefaultValue(0)]
    [Range(0, 120, ErrorMessage = "MinLevel must be between 0 and 120.")]
    public int MinLevel { get; set; }
    
    [DefaultValue(0)]
    [Range(0, 120, ErrorMessage = "ConditionLevel must be between 0 and 100.")]
    public int ConditionLevel { get; set; }

    [Required]
    public short Class { get; set; }

    [Required]
    public int Type { get; set; }
    
    [Required]
    public int LifeType { get; set; }

    [Required]
    public int TimeType { get; set; }
    
    
}