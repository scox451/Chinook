using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Chinook.Core.Models;
using Chinook.Core.Repos;

namespace chinook.api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TrackController : ControllerBase
    {
        private readonly ILogger<TrackController> _logger;

        public TrackController(ILogger<TrackController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Track> Get()
        {
            var results = new TrackRepo().GetTracks();
            return results;
        }
    }
}
