using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission6Assignment.Models
{
    public class Movie
    {
        [Key]
        [Required]
        public int MovieId { get; set; } // Primary key
        [ForeignKey("CategoryId")]
        [Required(ErrorMessage = "Please select a category.")]
        public int? CategoryId { get; set; } // Foreign key
        public Category? Category { get; set; }
        public string Title { get; set; }
        [Range(1888, Int32.MaxValue, ErrorMessage = "You must enter a valid year.")]
        public int Year { get; set; }
        public string? Director { get; set; }
        public string? Rating { get; set; }
        public bool Edited { get; set; }
        public string? LentTo { get; set; }
        public bool CopiedToPlex { get; set; }
        [StringLength(25, ErrorMessage = "Notes cannot exceed 25 characters.")]
        public string? Notes { get; set; }

    }  
}