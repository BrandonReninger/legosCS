using System.ComponentModel.DataAnnotations;

namespace legos.Models
{
    public class Set
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int Pieces { get; set; }
        public string Creator { get; set; }
    }

    public class BlockSetViewModel : Set
    {
        public int blockSetId { get; set; }
        public string Block { get; set; }
    }
}