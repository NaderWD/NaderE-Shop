using System.ComponentModel.DataAnnotations;
using NaderE_Shop.Application.DTOs.BaseDTO;

namespace NaderE_Shop.Application.DTOs.CustomerDTO
{
    public class CreateCustomerDto : BaseDto
    {
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        [Required]
        [MaxLength(255)]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [DataType(DataType.ImageUrl)]
        public string ProfilePicture { get; set; }

        public int AddressId { get; set; }

        public int ShopUserId { get; set; }
    }
}
