﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductService.Models.Data
{
    [Table("Products")]
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public int CategoryId { get; set; }


        [ForeignKey("CategoryId")]
        public virtual Category? Category { get; set; }

    }
}
