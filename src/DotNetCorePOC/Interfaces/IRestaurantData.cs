using DotNetCorePOC.Models;
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
        List<Restaurant> _restuarnts;
        public InMemoryRestaurantData()
        {
            _restuarnts = new List<Restaurant>
            {
                new Restaurant {Id=1,Name="Res1" },
                new Restaurant {Id=2, Name= "Res2" },
                new Restaurant {Id=3, Name="Res3" }
            };
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return _restuarnts;
        }
    }
}
