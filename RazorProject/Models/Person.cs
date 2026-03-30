using System.ComponentModel.DataAnnotations;

namespace Razor1.Models
{
    public class Person
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Имя обязательно")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Имя должно быть от 2 до 50 символов")]
        [Display(Name = "Имя")]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Фамилия обязательна")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Фамилия должна быть от 2 до 50 символов")]
        [Display(Name = "Фамилия")]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email обязателен")]
        [EmailAddress(ErrorMessage = "Неверный формат email")]
        [Display(Name = "Email")]
        public string Email { get; set; } = string.Empty;

        [Phone(ErrorMessage = "Неверный формат телефона")]
        [Display(Name = "Телефон")]
        public string? Phone { get; set; }

        [Range(0, 120, ErrorMessage = "Возраст должен быть от 0 до 120 лет")]
        [Display(Name = "Возраст")]
        public int Age { get; set; }

        [MaxLength(200, ErrorMessage = "Краткое био не может превышать 200 символов")]
        [Display(Name = "Краткое био")]
        public string? ShortBio { get; set; }

        [Display(Name = "Фото профиля")]
        public string? AvatarUrl { get; set; }
    }
}