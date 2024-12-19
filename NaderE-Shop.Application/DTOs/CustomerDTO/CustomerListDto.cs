using System.ComponentModel.DataAnnotations;
using NaderE_Shop.Application.DTOs.BaseDTO;

namespace NaderE_Shop.Application.DTOs.CustomerDTO
{
    public class CustomerListDto : BaseDto
    {
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        public int ShopUserId { get; set; }
    }
}
