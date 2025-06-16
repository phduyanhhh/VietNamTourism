using System.ComponentModel.DataAnnotations;

namespace VietNamTourism.Users.Dto;

public class ChangeUserLanguageDto
{
    [Required]
    public string LanguageName { get; set; }
}