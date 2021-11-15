using System.Collections.Generic;

public class Albums
{
    public long AlbumId { get; set; }
    public string Title { get; set; }
    public long ArtistId { get; set; }

    public IEnumerable<Tracks> Tracks { get; set; }
}