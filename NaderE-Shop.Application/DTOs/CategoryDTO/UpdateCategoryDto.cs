using System.ComponentModel.DataAnnotations;
using NaderE_Shop.Application.DTOs.BaseDTO;

namespace NaderE_Shop.Application.DTOs.CategoryDTO
{
    public class UpdateCategoryDto : BaseDto
    {
        [Required]
        [MaxLength(255)]
        public string Title { get; set; }

        [Required]
        [MaxLength(2000)]
        public string Description { get; set; }

        [DataType(DataType.ImageUrl)]
        public string Image { get; set; }
    }
}
