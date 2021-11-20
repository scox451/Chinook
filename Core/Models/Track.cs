using System;
using System.Collections.Generic;
using Chinook.Core.Models;

#nullable disable

namespace Chinook.Core.Models
{
    public partial class Track
    {
        public Track()
        {
            InvoiceItems = new HashSet<InvoiceItem>();
            PlaylistTracks = new HashSet<PlaylistTrack>();
        }

        public long TrackId { get; set; }
        public string Name { get; set; }
        public long? AlbumId { get; set; }
        public long MediaTypeId { get; set; }
        public long? GenreId { get; set; }
        public string Composer { get; set; }
        public long Milliseconds { get; set; }
        public long? Bytes { get; set; }
        public byte[] UnitPrice { get; set; }

        public virtual Album Album { get; set; }
        public virtual Genre Genre { get; set; }
        public virtual MediaType MediaType { get; set; }
        public virtual ICollection<InvoiceItem> InvoiceItems { get; set; }
        public virtual ICollection<PlaylistTrack> PlaylistTracks { get; set; }
    }
}
