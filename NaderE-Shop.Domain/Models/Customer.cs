using System.ComponentModel.DataAnnotations;

namespace NaderE_Shop.Domain.Models
{
    public class Customer : Base
    {
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        [Required]
        [MaxLength(255)]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [DataType((DataType.ImageUrl))]
        public string ProfilePicture { get; set; }

        public Address Address { get; set; }

        public int AddressId { get; set; }

        [Required]
        public ShopUser ShopUser { get; set; }

        public int ShopUserId { get; set; }

        public ShoppingCart ShoppingCart { get; set; }

        public int ShopingCartId { get; set; }
    }
}
