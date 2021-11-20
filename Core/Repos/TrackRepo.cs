using System.Collections.Generic;
using System.Linq;
using Chinook.Core.Models;

namespace Chinook.Core.Repos
{
    public class TrackRepo : BaseRepo
    {
        public IEnumerable<Track> GetTracks()
        {
            using (var context = Context())
            {
                var result = context.tracks.ToList();
                return result;
            }
        }

        public long Insert(Track track)
        {

            try
            {
                using (var context = Context())
                {
                    context.tracks.Add(track);
                    context.SaveChanges();
                    return track.TrackId;
                }
            }
            catch
            {
                return 0;
            }
        }
    }
}