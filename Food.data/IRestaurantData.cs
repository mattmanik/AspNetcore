using Food.core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Food.data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }

    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;
        public InMemoryRestaurantData()
        {

            restaurants = new List<Restaurant>()
            {
                new Restaurant {ID = 1,Location = "New York",cuisine = Restaurant.CuisineType.Italian, Name = "NY Kitchen" },
                new Restaurant {ID = 2,Location = "London",cuisine = Restaurant.CuisineType.Japanese, Name = "Uzumaki Restaurant" },
                new Restaurant {ID = 3,Location = "India",cuisine = Restaurant.CuisineType.Chinese, Name = "Shanghai Kitchen" }
            };
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return from r in restaurants
                   orderby r.Name
                   select r;
        }
    }   
}
