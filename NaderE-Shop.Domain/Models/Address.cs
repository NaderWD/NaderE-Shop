using System.ComponentModel.DataAnnotations;

namespace NaderE_Shop.Domain.Models
{
    public class Address : Base
    {
        [MaxLength(500)]
        public string Line1 { get; set; }

        [MaxLength(500)]
        public string? Line2 { get; set; }

        [MaxLength(500)]
        public string City { get; set; }

        [MaxLength(500)]
        public string Country { get; set; }

        [MaxLength(500)]
        [DataType(DataType.PostalCode)]
        public string PostalCode { get; set; }

        [MaxLength(500)]
        public string State { get; set; }
    }
}
