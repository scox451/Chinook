
public class Track
{
	public int TrackId { get; set; }
	public string Name { get; set; }
	public long AlbumId { get; set; }
	public long MediaTypeId { get; set; }
	public long GenreId { get; set; }
	public string Composer { get; set; }
	public long Milliseconds { get; set; }
	public long Bytes { get; set; }
	public decimal UnitPrice { get; set; }
}
