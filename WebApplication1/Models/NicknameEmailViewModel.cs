using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class NicknameEmailViewModel
    {
        [Required(ErrorMessage = "EmailIsRequired")]
        [EmailAddress(ErrorMessage = "EmailIsIncorrect")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "NicknameIsRequired")]
        [Display(Name = "Nickname")]
        [StringLength(30, ErrorMessage = "NicknameLengthIsIncorrect")]
        [RegularExpression(@"^[a-zA-ZĄąĘęŁłśŚżŻźŹ]*$", ErrorMessage = "NicknameShouldContainOnlyLetters")]
        public string Nickname { get; set; }
    }
}
