using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authorization;
using Chinook.Api.Resources;
using Microsoft.AspNetCore.Http;
using System.Diagnostics;
using Chinook.Api.Services;
using Chinook.Core.Models;

namespace chinook.api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [AllowAnonymous]
    [Authorize]
    public class TracksController : ControllerBase
    {
        private readonly ILogger<TracksController> _logger;

        public TracksController(ILogger<TracksController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("")]
        public TracksResult Get([FromQuery] Page page  )
        {
            Debug.WriteLine($"QuryString={HttpContext.Request.QueryString.ToString()}");
            
            var results = new TracksService().GetTracks(page);
            return results;
        }

        [HttpGet]
        [Route("api/tracks/{id}")]
        public TrackDetails Get(int id)
        {
            var results = new TracksService().Get(id);
            return results;
        }
    }
}
