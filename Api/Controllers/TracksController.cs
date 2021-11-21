using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Chinook.Core.Models;
using Chinook.Core.Repos;
using Microsoft.AspNetCore.Authorization;

namespace chinook.api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [AllowAnonymous]
    public class TracksController : ControllerBase
    {
        private readonly ILogger<TracksController> _logger;

        public TracksController(ILogger<TracksController> logger)
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
