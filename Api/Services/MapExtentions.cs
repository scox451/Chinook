using System;
using Chinook.Core.Models;
using Chinook.Api.Resources;

public static class MapExtensions
{
    public static T Map<TIn, T>(this TIn input, Func<TIn, T> mapper)
    {
        return mapper(input);
    }

    public static TrackDetails ToTrackDetails(this Track track)
    {

            var trackDetails = track.Map(track => new TrackDetails
            {
                TrackId = track.TrackId,
                Name = track.Name,
                AlbumTitle = track.Album.Title,
                AlbumResource = $"api/Albums/{track.AlbumId.ToString()}",
                MediaTypeName = track.MediaType.Name,
                GenreName = track.Genre.Name,
                Composer = track.Composer
            });

            return trackDetails;

    }
}