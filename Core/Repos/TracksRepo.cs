using System.Collections.Generic;
using System.Linq;
using Chinook.Core.Models;

namespace Chinook.Core.Repos
{
    public class TracksRepo : BaseRepo
    {
        public IEnumerable<Track> GetTracks(int limit=50, int offset=0)
        {
            using (var context = Context())
            {
                var result = context.tracks.AsQueryable();
                result = result.Skip(offset).Take(limit);

                return result.ToList();
            }
        }

        public Track Get(int id)
        {
             using (var context = Context())
            {
                var result = context.tracks.Where(x=>x.TrackId==id).SingleOrDefault();
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