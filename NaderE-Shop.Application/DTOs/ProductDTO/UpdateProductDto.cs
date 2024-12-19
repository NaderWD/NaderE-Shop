using System.ComponentModel.DataAnnotations;
using NaderE_Shop.Application.DTOs.BaseDTO;

namespace NaderE_Shop.Application.DTOs.ProductDTO
{
    public class UpdateProductDto : BaseDto
    {
        [Required]
        [MaxLength(255)]
        public string Title { get; set; }

        [Required]
        [MaxLength(2000)]
        public string Description { get; set; }

        public DateTime ProduceDate { get; set; }

        public DateTime ExpirationDate { get; set; }

        public int CategoryId { get; set; }

        [DataType(DataType.ImageUrl)]
        public string Image { get; set; }

        public string Brand { get; set; }

        public string Color { get; set; }
    }
}
