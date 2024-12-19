using NaderE_Shop.Application.DTOs.BaseDTO;
using System.ComponentModel.DataAnnotations;

namespace NaderE_Shop.Application.DTOs.CategoryDTO
{
    public class CategoryListDto : BaseDto
    {
        [Required]
        [MaxLength(255)]
        public string Title { get; set; }
    }
}
