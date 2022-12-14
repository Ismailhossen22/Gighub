using System.ComponentModel.DataAnnotations;

namespace GigHub.Models
{
    public class Genre
    {
        public byte Id { get; set; }
        [Required]
        [StringLength(225)]
        public string Name { get; set; }
    }
}