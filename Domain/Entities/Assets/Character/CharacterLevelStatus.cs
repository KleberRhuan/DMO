using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Assets.Character;

public class CharacterLevelStatus {
    [Key]
    public long Id { get; set; }

    [Required]
    [Range(1, int.MaxValue)]
    public int Type { get; set; }

    [Required]
    [Range(1, byte.MaxValue)]
    public byte Level { get; set; }

    [Required]
    [Range(0, long.MaxValue)]
    public long ExpValue { get; set; }

    [Required]
    [Range(0, int.MaxValue)]
    [Column(name: "ASValue")]
    public int AsValue { get; set; }

    [Required]
    [Range(0, int.MaxValue)]
    [Column(name: "ARValue")]
    public int ArValue { get; set; }

    [Required]
    [Range(0, int.MaxValue)]
    [Column(name: "ATValue")]
    public int AtValue { get; set; }

    [Required]
    [Range(0, int.MaxValue)]
    [Column(name: "BLValue")]
    public int BlValue { get; set; }

    [Required]
    [Range(0, int.MaxValue)]
    [Column(name: "CTValue")]
    public int CtValue { get; set; }

    [Required]
    [Range(0, int.MaxValue)]
    [Column(name: "DEValue")]
    public int DeValue { get; set; }

    [Required]
    [Range(0, int.MaxValue)]
    [Column(name: "DSValue")]
    public int DsValue { get; set; }

    [Required]
    [Range(0, int.MaxValue)]
    [Column(name: "EVValue")]
    public int EvValue { get; set; }

    [Required]
    [Range(0, int.MaxValue)]
    [Column(name: "HPValue")]
    public int HpValue { get; set; }

    [Required]
    [Range(0, int.MaxValue)]
    [Column(name: "HTValue")]
    public int HtValue { get; set; }

    [Required]
    [Range(0, int.MaxValue)]
    [Column(name: "MSValue")]
    public int MsValue { get; set; }

    [Required]
    [Range(0, int.MaxValue)]
    [Column(name: "WSValue")]
    public int WsValue { get; set; }
}