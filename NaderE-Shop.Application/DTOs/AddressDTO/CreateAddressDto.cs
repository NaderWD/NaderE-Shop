using System.ComponentModel.DataAnnotations;
using NaderE_Shop.Application.DTOs.BaseDTO;

namespace NaderE_Shop.Application.DTOs.AddressDTO
{
    public class CreateAddressDto : BaseDto
    {
        [MaxLength(500)]
        public string Line1 { get; set; }

        [MaxLength(500)]
        public string Line2 { get; set; }

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
