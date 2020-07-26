using System;
using System.ComponentModel.DataAnnotations;

namespace Commander.Models
{
    public class Command
    {
        [Key]
        public int Id { get; set; }

        public string CommandId { get; set; } = Guid.NewGuid().ToString();

        [Required]
        [MaxLength(250)]
        public string HowTo { get; set; }

        [Required]
        public string Line { get; set; }

        [Required]
        public string Platform { get; set; }

        public System.DateTime CreatedAt { get; set; } = System.DateTime.UtcNow;

        [Timestamp]
        public byte[] Date { get; set; }
    }
}