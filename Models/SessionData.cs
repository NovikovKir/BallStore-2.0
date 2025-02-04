using System.ComponentModel.DataAnnotations;

namespace ballstore.Models
{
    public class SessionData
    {
        [Key]
        public string Id { get; set; }
        public string Value { get; set; }
        public DateTime ExpiresAt { get; set; }
    }
} 