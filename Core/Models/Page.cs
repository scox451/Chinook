using System;

namespace Chinook.Core.Models
{
    public class Page
    {
        private readonly int defaultLimit = 20;
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
        public int Previous => Math.Max(Offset - Limit, defaultOffset);
        public int Next => (Offset + Limit <= Count) ? 
            Offset + Limit : 
            defaultOffset;
        public int PageIndex
        {
            get
            {
                if(Limit==0)
                    return 0;

                var pageNumber = (int) Math.Floor((decimal)Offset/(decimal)Limit);
                return Math.Max( pageNumber, 0);
            }

            set
            {
                Offset = ((value + 1) * Limit) - Limit;
            }
        }
    }


}