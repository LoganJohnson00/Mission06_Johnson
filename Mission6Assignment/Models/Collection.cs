using System.ComponentModel.DataAnnotations;

namespace Mission6Assignment.Models
{
    public class Collection
    {
        public int Id { get; set; } // Primary key
        public string Category { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Director { get; set; }
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public string? LentTo { get; set; }
        [StringLength(25, ErrorMessage = "Notes cannot exceed 25 characters.")]
        public string? Notes { get; set; }

    }  
}