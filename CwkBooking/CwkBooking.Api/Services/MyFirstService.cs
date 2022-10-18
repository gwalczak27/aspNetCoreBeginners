using CwkBooking.Domain.Models;
using System.Collections.Generic;

namespace CwkBooking.Api.Services
{
    public class MyFirstService
    {
        private readonly DataSource _dataSource;
        public MyFirstService(DataSource dataSource)
        {
            _dataSource = dataSource;
        }

        public List<Hotel> GetHotels()
        {
            return _dataSource.Hotels;
        }
    }
}
