using System.ComponentModel.DataAnnotations;

namespace ballstore.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required]
        public decimal Price { get; set; }

        [StringLength(500)]
        public string Description { get; set; } = string.Empty;

        public string ImageUrl { get; set; } = string.Empty;

        public bool InStock { get; set; }
    }
} 