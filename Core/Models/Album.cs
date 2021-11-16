using System.Collections.Generic;

 namespace Chinook.Core.Models
 {
    public class Album
    {
        public long AlbumId { get; set; }
        public string Title { get; set; }
        public long ArtistId { get; set; }

        public IEnumerable<Track> Tracks { get; set; }
    }
 }