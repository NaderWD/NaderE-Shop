using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NaderE_Shop.Domain.Models
{
    public class ShoppingCart : Base
    {
        [Required]
        public Order Order { get; set; }

        public int OrderId { get; set; }

        public Address Address { get; set; }

        public int AddressId { get; set; }

        [Required]
        public ShopUser ShopUser { get; set; }

        public int ShopUserId { get; set; }

        [Required]
        [DefaultValue(false)]
        public bool IsPaid { get; set; }
    }
}
