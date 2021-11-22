namespace Chinook.Core.Models
{
    public class Pagination
    {
        public int Limit { get; set; }
        public int Offset { get; set; }
        public int Next { get; set; }
        public int Previous { get; set; }
    }


}