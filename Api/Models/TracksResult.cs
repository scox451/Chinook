using System.Collections.Generic;
using Chinook.Core.Models;

namespace Chinook.Api.Models
{
    public class TracksResult
    {
        public IEnumerable<TrackDetails> Data { get; set; }

        public Page Page {get;set;}

    }

}