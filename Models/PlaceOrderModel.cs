using System.ComponentModel.DataAnnotations;

namespace ballstore.Models
{
    public class PlaceOrderModel
    {
        [Required(ErrorMessage = "Адрес доставки обязателен")]
        public string DeliveryAddress { get; set; } = string.Empty;

        [Required(ErrorMessage = "Город доставки обязателен")]
        public string DeliveryCity { get; set; } = string.Empty;

        public string? Comment { get; set; }
    }
} 