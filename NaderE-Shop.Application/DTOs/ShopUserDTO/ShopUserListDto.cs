using NaderE_Shop.Application.DTOs.BaseDTO;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NaderE_Shop.Application.DTOs.ShopUserDTO
{
    public class ShopUserListDto : BaseDto
    {
        [Required]
        [MaxLength(255)]
        public string UserName { get; set; }

        [Required]
        [MaxLength(500)]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }

        [Required]
        [DefaultValue(false)]
        public bool IsAdmin { get; set; }
    }
}
