using System.ComponentModel.DataAnnotations;

namespace TestMPWAAspAbp.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}