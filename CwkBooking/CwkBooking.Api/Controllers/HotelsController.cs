using CwkBooking.Domain.Models;
using Microsoft.AspNetCore.Mvc;
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
        public HotelsController(DataSource dataSource)
        {
            _dataSource = dataSource;
        }

        // will execute on Get
        [HttpGet]
        public IActionResult GetAllHotels()
        {
            var hotels = _dataSource.Hotels;
            return Ok(hotels);
        }

        [Route("{id}")]
        [HttpGet]
        public IActionResult GetHotelById(int id)
        {
            var hotels = _dataSource.Hotels;
            var hotel = hotels.FirstOrDefault(h => h.HotelId == id);

            if (hotel == null)
                return NotFound();

            return Ok(hotel);
        }

        [HttpPost]
        public IActionResult CreateHotel([FromBody] Hotel hotel)
        {
            var hotels = _dataSource.Hotels;
            hotels.Add(hotel);
            return CreatedAtAction(nameof(GetHotelById), new { id = hotel.HotelId }, hotel);
        }

        [Route("{id}")]
        [HttpPut]
        public IActionResult UpdateHotel([FromBody] Hotel updated, int id)
        {
            var hotels = _dataSource.Hotels;
            var old = hotels.FirstOrDefault(h => h.HotelId == id);
            
            if(old == null)
            {
                return NotFound("No resource with the corresponding ID found.");
            }

            hotels.Remove(old);
            hotels.Add(updated);
            return NoContent();
        }

        [Route("{id}")]
        [HttpDelete]
        public IActionResult DeleteHotel(int id)
        {
            var hotels = _dataSource.Hotels;
            var toDelete = hotels.FirstOrDefault(h => h.HotelId == id);
            
            if (toDelete == null)
            {
                return NotFound("No resource found with the provided ID.");
            }
            
            hotels.Remove(toDelete);
            return NoContent();
        }


    }
}
