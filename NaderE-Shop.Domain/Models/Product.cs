﻿using System.ComponentModel.DataAnnotations;

namespace NaderE_Shop.Domain.Models
{
    public class Product : Base
    {
        [Required]
        [MaxLength(255)]
        public string Title { get; set; }

        [Required]
        [MaxLength(2000)]
        public string? Description { get; set; }

        public DateTime? ProduceDate { get; set; }

        public DateTime? ExpirationDate { get; set; }

        public Category? Category { get; set; }

        public int? CategoryId { get; set; }

        [DataType((DataType.ImageUrl))]
        public string? Image { get; set; }

        public string? Brand { get; set; }

        public string? Color { get; set; }

        public Comment? Comment { get; set; }
        public int? CommentId { get; set; }
    }
}
