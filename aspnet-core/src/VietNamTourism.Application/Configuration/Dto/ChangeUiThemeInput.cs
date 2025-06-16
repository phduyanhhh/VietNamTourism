using System.ComponentModel.DataAnnotations;

namespace VietNamTourism.Configuration.Dto;

public class ChangeUiThemeInput
{
    [Required]
    [StringLength(32)]
    public string Theme { get; set; }
}
