using System.Collections.Generic;
using System.Linq;
using Chinook.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Chinook.Core.Repos
{
    public class TracksRepo : BaseRepo
    {
        public IEnumerable<Track> GetTracks(Page page = null)
        {
            page = page ?? new Page();

            using (var context = Context())
            {
                var query = context.tracks
                    .Include(i=>i.Album)
                    .Include(i=>i.MediaType)
                    .Include(i=>i.Genre)
                    .AsQueryable();
                    
                page.Count = query.Count();
                query = query.OrderBy(i=>i.TrackId).Skip(page.Offset)
                .Take(page.Limit);

                var result = query.ToList();
                return result; 
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