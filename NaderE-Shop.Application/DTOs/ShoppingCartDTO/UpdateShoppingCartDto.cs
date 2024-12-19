using NaderE_Shop.Application.DTOs.BaseDTO;
using NaderE_Shop.Application.DTOs.OrderDTO;
using System.ComponentModel.DataAnnotations;

namespace NaderE_Shop.Application.DTOs.ShoppingCartDTO
{
    public class UpdateShoppingCartDto : BaseDto
    {
        [Required]
        public OrderDto Order { get; set; }

        public int OrderId { get; set; }

        public int AddressId { get; set; }
    }
}
