using System.ComponentModel.DataAnnotations;
using NaderE_Shop.Application.DTOs.BaseDTO;
using NaderE_Shop.Application.DTOs.ShopUserDTO;

namespace NaderE_Shop.Application.DTOs.CommentDTO
{
    public class CommentDto : BaseDto
    {
        [Required][MaxLength(255)] public string? Title { get; set; }

        [Required][DataType(DataType.Text)] public string? Text { get; set; }

        [Required] public ShopUserDto ShopUser { get; set; }

        public int ShopUserId { get; set; }
    }
}
