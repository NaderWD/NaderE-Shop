using System.ComponentModel.DataAnnotations;

namespace NaderE_Shop.Domain.Models
{
    public class Category : Base
    {
        [Required]
        [MaxLength(255)]
        public string Title { get; set; }

        [Required]
        [MaxLength(2000)]
        public string Description { get; set; }

        [DataType((DataType.ImageUrl))]
        public string Image { get; set; }
    }
}
