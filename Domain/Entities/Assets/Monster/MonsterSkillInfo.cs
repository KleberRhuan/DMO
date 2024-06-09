using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.Assets.Monster;

public class MonsterSkillInfo {
    [Key]
    public long Id { get; set; }

    [Required]
    [Range(1, int.MaxValue)]
    public int SkillId { get; set; }

    [Required]
    [Range(int.MinValue, int.MaxValue)]
    public int MinValue { get; set; }

    [Required]
    [Range(int.MinValue, int.MaxValue)]
    public int MaxValue { get; set; }

    [Required]
    [Range(0, int.MaxValue)]
    public int CastingTime { get; set; }

    [Required]
    [Range(0, int.MaxValue)]
    public int Cooldown { get; set; }

    [Required]
    [Range(1, byte.MaxValue)]
    public byte TargetCount { get; set; }

    [Required]
    [Range(1, byte.MaxValue)]
    public byte TargetMin { get; set; }

    [Required]
    [Range(1, byte.MaxValue)]
    public byte TargetMax { get; set; }

    [Required]
    [Range(0, byte.MaxValue)]
    public byte UseTerms { get; set; }

    [Required]
    [Range(1, int.MaxValue)]
    public int RangeId { get; set; }

    [Required]
    [Range(0, (double)decimal.MaxValue)]
    public decimal AnimationDelay { get; set; }

    [Required]
    [Range(0, byte.MaxValue)]
    public byte ActiveType { get; set; }

    [Required]
    [Range(1, int.MaxValue)]
    public int SkillType { get; set; }

    [Required]
    [Range(0, (double)decimal.MaxValue)]
    public decimal NoticeTime { get; set; }

    [Required]
    [Range(1, int.MaxValue)]
    public int Type { get; set; }
}