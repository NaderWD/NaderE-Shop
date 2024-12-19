using NaderE_Shop.Application.DTOs.BaseDTO;

namespace NaderE_Shop.Application.DTOs.ShoppingCartDTO
{
    public class CreateShoppingCartDto : BaseDto
    {
        public int OrderId { get; set; }

        public int AddressId { get; set; }

        public int ShopUserId { get; set; }
    }
}
