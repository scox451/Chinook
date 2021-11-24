using System.Linq;
using Chinook.Api.Resources;
using Chinook.Core.Models;
using Chinook.Core.Repos;


namespace Chinook.Api.Services
{

    public class TracksService
    {
        public TracksResult GetTracks(Page page)
        {
            var data = new TracksRepo().GetTracks(page)
                                .Select(i => i.ToTrackDetails());
            
            var trackResult = new TracksResult
            {
                Data = data,
                Page = page
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