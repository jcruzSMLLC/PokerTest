using System.ComponentModel.DataAnnotations;

namespace PokerTest.Data.Models
{
    public class Story
    {
        public int Id { get; set; }
        public int DevopsNumber { get; set; }
        public Point? Point { get; set; }
        public string? Title { get; set; }
        public string? Notes { get; set; }
        public Sprint? Sprint { get; set; }

    }
}
