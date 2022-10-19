using CwkBooking.Domain.Models;
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
        private readonly DataSource _dataSource;
        private readonly ILogger<HotelsController> _logger;
        
        public HotelsController(ILogger<HotelsController> logger)
        {
            _logger = logger;

        }

        // will execute on Get
        [HttpGet]
        public IActionResult GetAllHotels()
        {
            return Ok();
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
