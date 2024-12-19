using System.ComponentModel.DataAnnotations;
using NaderE_Shop.Application.DTOs.BaseDTO;

namespace NaderE_Shop.Application.DTOs.CommentDTO
{
    public class UpdateCommentDto : BaseDto
    {
        [Required]
        [MaxLength(255)]
        public string? Title { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string? Text { get; set; }

        public int ShopUserId { get; set; }
    }
}
