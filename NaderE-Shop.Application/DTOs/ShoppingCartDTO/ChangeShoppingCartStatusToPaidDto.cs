using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NaderE_Shop.Application.DTOs.ShoppingCartDTO
{
    public class ChangeShoppingCartStatusToPaidDto
    {
        [Required]
        [DefaultValue(false)]
        public bool IsPaid { get; set; }
    }
}
