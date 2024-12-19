using NaderE_Shop.Application.DTOs.AddressDTO;
using System.ComponentModel.DataAnnotations;
using NaderE_Shop.Application.DTOs.BaseDTO;
using NaderE_Shop.Application.DTOs.ShoppingCartDTO;
using NaderE_Shop.Application.DTOs.ShopUserDTO;

namespace NaderE_Shop.Application.DTOs.CustomerDTO
{
    public class CustomerDto : BaseDto
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

        public AddressDto Address { get; set; }

        public int AddressId { get; set; }

        [Required]
        public ShopUserDto ShopUser { get; set; }

        public int ShopUserId { get; set; }

        public ShoppingCartDto ShoppingCart { get; set; }

        public int ShopingCartId { get; set; }
    }
}
