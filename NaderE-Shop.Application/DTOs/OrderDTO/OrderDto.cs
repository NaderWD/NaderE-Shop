using System.ComponentModel.DataAnnotations;
using NaderE_Shop.Application.DTOs.BaseDTO;
using NaderE_Shop.Application.DTOs.ProductDTO;

namespace NaderE_Shop.Application.DTOs.OrderDTO
{
    public class OrderDto : BaseDto
    {
        [Required]
        public ProductDto Product { get; set; }

        public int ProductId { get; set; }
    }
}
