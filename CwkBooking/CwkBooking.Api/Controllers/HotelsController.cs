using CwkBooking.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CwkBooking.Api.Controllers
{

    // /hotels
    [ApiController]
    [Route("api/[controller]")]
    public class HotelsController : Controller
    {
        private readonly ILogger<HotelsController> _logger;
        private readonly HttpContext _http;

        public HotelsController(ILogger<HotelsController> logger,
            IHttpContextAccessor httpContextAccessor)
        {
            _logger = logger;
            _http = httpContextAccessor.HttpContext;
        }

        // will execute on Get
        [HttpGet]
        public IActionResult GetAllHotels()
        {
            HttpContext.Request.Headers.TryGetValue("my-middleware-header", out var headerDate);
            return Ok(headerDate);
        }

        [Route("{id}")]
        [HttpGet]
        public IActionResult GetHotelById(int id)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult CreateHotel([FromBody] Hotel hotel)
        {
            return Ok();
        }

        [Route("{id}")]
        [HttpPut]
        public IActionResult UpdateHotel([FromBody] Hotel updated, int id)
        {
            return NoContent();
        }

        [Route("{id}")]
        [HttpDelete]
        public IActionResult DeleteHotel(int id)
        {
            return NoContent();
        }


    }
}
