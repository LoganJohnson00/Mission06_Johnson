using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Mission6Assignment.Models;

public class Category
{
    [Key]
    public int CategoryId { get; set; }
    public string CategoryName { get; set; } =  string.Empty;
    
    public List<Movie> Movies { get; set; } = new();
}