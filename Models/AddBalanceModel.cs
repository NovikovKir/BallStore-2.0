using System.ComponentModel.DataAnnotations;

namespace ballstore.Models
{
    public class AddBalanceModel
    {
        [Required]
        [Range(1, 1000000)]
        public decimal Amount { get; set; }
    }
} 