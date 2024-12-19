using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace NaderE_Shop.Domain.Models
{
    public abstract class Base
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime AddedDate { get; set; }

        [Required]
        [DefaultValue(false)]
        public bool IsDeleted { get; set; }
    }
}
