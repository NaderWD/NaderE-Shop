using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using NaderE_Shop.Application.DTOs.BaseDTO;

namespace NaderE_Shop.Application.DTOs.ShopUserDTO
{
    public class ShopUserDto : BaseDto
    {
        [Required]
        [MaxLength(255)]
        public string UserName { get; set; }

        [Required]
        [MaxLength(255)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [MaxLength(255)]
        [DataType(DataType.Password)]
        public string RepeatPassword { get; set; }

        [Required]
        [MaxLength(500)]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }

        [Required]
        [DefaultValue(false)]
        public bool IsAdmin { get; set; }
    }
}
