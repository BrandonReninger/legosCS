namespace legos.Models
{
    public class Block
    {
        public int Id { get; set; }
        public string Shape { get; set; }
        public string Color { get; set; }
        public int Width { get; set; }
    }

    public class BlockSet
    {
        public int Id { get; set; }
        public int SetId { get; set; }
        public int BlockId { get; set; }
    }
}