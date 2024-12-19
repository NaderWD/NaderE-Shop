using System.ComponentModel.DataAnnotations;

namespace NaderE_Shop.Domain.Models
{
    public class Comment : Base
    {
        [Required]
        [MaxLength(255)]
        public string Title { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Text { get; set; }

        [Required]
        public ShopUser ShopUser { get; set; }

        public int ShopUserId { get; set; }
    }
}
