using CwkBooking.Domain.Models;
using System.Collections.Generic;

namespace CwkBooking.Api
{
    public class DataSource
    {
        public DataSource()
        {
            Hotels = GetHotels();
        }

        public List<Hotel> Hotels { get; set; }

        private List<Hotel> GetHotels()
        {
            return new List<Hotel>
            {
                new Hotel
                {
                    HotelId = 1,
                    Name = "Sneem Hotel",
                    Stars = 3,
                    Country = "Ireland",
                    City = "Sneem",
                    Address = "Kerry Street",
                    Description = "Some nice description"

                },
                new Hotel
                {
                    HotelId = 2,
                    Name = "Parknasilla Resort",
                    Stars = 4,
                    Country = "Ireland",
                    City = "Sneem",
                    Address = "Ukrainian Heroes Street",
                    Description = "Some nice description 2"
                }
            };
        }
    }

    
}
