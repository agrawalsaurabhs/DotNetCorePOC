using DotNetCorePOC.Models;
using DotNetCorePOC.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCorePOC.Interfaces
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }

    public class InMemoryRestaurantData : IRestaurantData
    {
        private readonly DotNetCorePOCDbContext _context;
        public InMemoryRestaurantData(DotNetCorePOCDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return _context.Restaurants;
        }
    }
}
