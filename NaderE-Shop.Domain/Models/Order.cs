using System.ComponentModel.DataAnnotations;

namespace NaderE_Shop.Domain.Models
{
    public class Order : Base
    {
        [Required]
        public Product Product { get; set; }

        public int ProductId { get; set; }
    }
}
