﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lugx2025.Data.Entities
{
    public class GameModel
    {
        [Key]
        public int Id { get; set; }
        public string PhotoPath { get; set; } = null!;
        [Required]
        public string Name { get; set; } = null!;
        [Required]
        public string Description { get; set; } = null!; 
        [Required]
        public string ShortDescription { get; set; } = null!;
        [Range(0,float.MaxValue)]
        public float PriceBeforeSale { get; set; }
        [Range(0, float.MaxValue)]
        public float PriceAfterSale { get; set; }
        [Range(0, int.MaxValue)]
        public int AvailableCount { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }
        [Range(0, int.MaxValue)]
        public int PurchaseCount { get; set; }
        public int GenreId { get; set; }
        public int UploaderId { get; set; }
        public int VisitorsNumber { get; set; }
        public float StarsCount {  get; set; }
        public int ReviewsNumber { get; set; }
        public string GameCode { get; set; } = null!;
    }
}
