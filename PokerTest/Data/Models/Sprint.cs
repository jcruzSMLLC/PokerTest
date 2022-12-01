using System.ComponentModel.DataAnnotations;

namespace PokerTest.Data.Models
{
    public class Sprint
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string? Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<Story>? Stories { get; set; }
    }
}
