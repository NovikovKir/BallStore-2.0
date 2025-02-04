using System.ComponentModel.DataAnnotations;

namespace ballstore.Models
{
    public class UpdateBalanceModel
    {
        [Required(ErrorMessage = "Сумма пополнения обязательна")]
        [Range(1, 750000, ErrorMessage = "Сумма должна быть от 1 до 1 000 000 рублей")]
        public decimal Amount { get; set; }

        [Required(ErrorMessage = "Номер карты обязателен")]
        public string CardNumber { get; set; } = string.Empty;

        public string ExpiryDate { get; set; } = string.Empty;

        public string CVV { get; set; } = string.Empty;
    }
} 