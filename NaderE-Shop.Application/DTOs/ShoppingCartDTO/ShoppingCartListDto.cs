using NaderE_Shop.Application.DTOs.AddressDTO;
using NaderE_Shop.Application.DTOs.OrderDTO;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using NaderE_Shop.Application.DTOs.BaseDTO;
using NaderE_Shop.Application.DTOs.ShopUserDTO;

namespace NaderE_Shop.Application.DTOs.ShoppingCartDTO
{
    public class ShoppingCartListDto : BaseDto
    {
        [Required]
        public OrderDto Order { get; set; }

        public AddressDto Address { get; set; }

        [Required]
        public ShopUserDto ShopUser { get; set; }

        [Required]
        [DefaultValue(false)]
        public bool Status { get; set; }
    }
}
