using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace NaderE_Shop.Domain.Models
{
    public class ShopUser : Base
    {
        [Required]
        [MaxLength(255)]
        public string UserName { get; set; }

        [Required]
        [MaxLength(255)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [MaxLength(255)]
        [DataType(DataType.Password)]
        public string RepeatPassword { get; set; }

        [Required]
        [MaxLength(500)]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }

        [Required]
        [DefaultValue(false)]
        public bool IsAdmin { get; set; }
    }
}
