using System.ComponentModel.DataAnnotations;
using NaderE_Shop.Application.DTOs.BaseDTO;

namespace NaderE_Shop.Application.DTOs.CommentDTO
{
    public class CommentListDto : BaseDto
    {
        [Required]
        [MaxLength(255)]
        public string Title { get; set; }

    }
}
