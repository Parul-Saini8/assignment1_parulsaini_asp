using System;
using System.ComponentModel.DataAnnotations;

namespace ImperialRulers.Models
{
    public class Ruler
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string BrandName { get; set; }

        [Display(Name = "Manufacture Date")]
        [DataType(DataType.Date)]
        public DateTime ManufactureDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(30)]
        public string Types { get; set; }

        public decimal Price { get; set; }

        [Display(Name = "Length(M)")]
        public decimal Length { get; set; }

        public string Material { get; set; }

        public string Rating { get; set; }
    }
}