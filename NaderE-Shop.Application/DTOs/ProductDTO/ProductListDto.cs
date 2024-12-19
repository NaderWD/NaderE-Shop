using NaderE_Shop.Application.DTOs.BaseDTO;
using NaderE_Shop.Application.DTOs.CategoryDTO;
using System.ComponentModel.DataAnnotations;

namespace NaderE_Shop.Application.DTOs.ProductDTO
{
    public class ProductListDto : BaseDto
    {
        [Required]
        [MaxLength(255)]
        public string Title { get; set; }

        public CategoryDto Category { get; set; }

        public string Color { get; set; }

    }
}
