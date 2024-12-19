﻿using NaderE_Shop.Application.DTOs.BaseDTO;
using System.ComponentModel.DataAnnotations;

namespace NaderE_Shop.Application.DTOs.AddressDTO
{
    public class AddressDto : BaseDto
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