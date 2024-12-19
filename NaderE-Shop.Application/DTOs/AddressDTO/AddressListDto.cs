using System.ComponentModel.DataAnnotations;
using NaderE_Shop.Application.DTOs.BaseDTO;

namespace NaderE_Shop.Application.DTOs.AddressDTO
{
    public class AddressListDto : BaseDto
    {
        [MaxLength(500)]
        public string City { get; set; }

        [MaxLength(500)]
        public string Country { get; set; }

        [MaxLength(500)]
        public string State { get; set; }
    }
}
