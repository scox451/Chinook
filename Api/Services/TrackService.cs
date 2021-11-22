using System.Linq;
using Chinook.Api.Models;
using Chinook.Core.Models;
using Chinook.Core.Repos;


namespace Chinook.Api.Services
{

    public class TracksService
    {
        private readonly int defaultLimit = 50;
        readonly int defaultOffset = 0;

        public TracksResult GetTracks(int? limit = null, int? offset = null)
        {
            limit = limit ?? defaultLimit;
            offset = offset ?? defaultOffset;

            var trackResult = new TracksResult{
                Data = new TracksRepo().GetTracks(limit.Value, offset.Value)
                    .Select(i=>i.ToTrackDetails()),
                    Pagination = new Pagination {
                        Limit=limit.Value,
                        Offset=offset.Value
                    }
            
            };

            return trackResult;
        }

        public TrackDetails Get(int id)
        {
            var track = new TracksRepo().Get(id);
            var trackDetails = track.ToTrackDetails();

            return trackDetails;
        }

        
    }
}