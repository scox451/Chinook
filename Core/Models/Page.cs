using System;

namespace Chinook.Core.Models
{
    public class Page
    {
        private readonly int defaultLimit = 50;
        private readonly int defaultOffset = 0;

 public Page()
        {
            Limit = defaultLimit;
            Offset = defaultOffset;
        }
        public Page(int limit, int offset)
        {
            Limit = limit <= 0 ? defaultLimit : limit;
            Offset = offset <= 0 ? defaultOffset : offset;
        }
        public int Limit { get; set; }
        public int Offset { get; set; }
        public int Count { get; set; }
        public int Previous => GetPrevious();
        public int Next => GetNext();

        private int GetPrevious()
        {
            int newOffset = Offset - Limit;
            return newOffset < 0 ? defaultOffset : newOffset;
        }

        private int GetNext()
        {
            int newOffset = Offset + Limit;

            if (newOffset > Count)
                return defaultOffset;

            return newOffset;
        }
    }


}