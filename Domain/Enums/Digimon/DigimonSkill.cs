using System.ComponentModel.DataAnnotations;

namespace Domain.Enums.Digimon;

public class DigimonSkill {
    [Key]
    public long Id { get; set; }

    [Required]
    [Range(1, int.MaxValue)]
    public int Type { get; set; }

    [Required]
    [Range(1, byte.MaxValue)]
    public byte Slot { get; set; }

    [Required]
    [Range(1, int.MaxValue)]
    public int SkillId { get; set; }
}