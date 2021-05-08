using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Food.core;
using Food.data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace orderFoodDelivery.Pages
{
    public class ListModel : PageModel
    {
        private readonly IConfiguration config;
        private readonly IRestaurantData restaurantData;

        public string show { get; set; }
        public IEnumerable<Restaurant> Restaurants { get; set; }
        public ListModel(IConfiguration config,IRestaurantData restaurantData)
        {
            this.config = config;
            this.restaurantData = restaurantData;
        }     
        public void OnGet()
        {
            show = config["Message"];
            Restaurants = restaurantData.GetAll();
        }

    }
}
