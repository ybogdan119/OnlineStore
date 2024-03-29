﻿using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [Range(0.01 , double.MaxValue)]
        [Column(TypeName = "decimal(18,4)")]
        public decimal Price { get; set; }

        /*[Required]
        [Display(Name = "Category")]
        public int CategoryId { get; set; }
        [ValidateNever]
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }*/

        [Required]
        [Display(Name = "Subcategory")]
        public int SubcategoryId { get; set; }
        [ValidateNever]
        [ForeignKey("SubcategoryId")]
        public virtual Subcategory Subcategory { get; set; }

        [Required]
        public int ManufacturerId { get; set; }
        [ValidateNever]
        public virtual Manufacturer Manufacturer { get; set; }

        public int? Discount { get; set; }


        [MaxLength(500)]
        public string? Description { get; set; }

        public string? ImageUrl { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
