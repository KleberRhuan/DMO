using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.Assets.Monster;

public class MonsterSkill {
    [Key]
    public long Id { get; set; }

    [Required]
    public int Type { get; set; }

    [Required]
    public int SkillId { get; set; }
}