using System.ComponentModel.DataAnnotations;

namespace Commander.Dtos
{
    public class CommandCreateDto
    {
        [MaxLength(259)]
        [Required]
        public string HowTo { set; get; }

        [Required]
        public string Line { set; get; }

        [Required]
        public string Platform { set; get; }
    }
}