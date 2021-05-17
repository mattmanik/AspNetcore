using Food.core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Food.data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetRestaurantByName(string name);
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
                new Restaurant {ID = 3,Location = "India",cuisine = Restaurant.CuisineType.Chinese, Name = "Shanghai Kitchen" },
                new Restaurant {ID = 4,Location = "California",cuisine = Restaurant.CuisineType.Italian, Name = "California Table" },
        
            };
        }

        public IEnumerable<Restaurant> GetRestaurantByName(string name=null)
        {
            return from r in restaurants
                   where string.IsNullOrEmpty(name) || r.Name.StartsWith(name) || r.Name.StartsWith(name.ToLower()) || r.Name.StartsWith(name.ToUpper())
                   orderby r.Name
                   select r;
        }
    }   
}
