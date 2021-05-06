using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace orderFoodDelivery.Pages
{
    public class ListModel : PageModel
    {
        private readonly IConfiguration config;

        public ListModel(IConfiguration config)
        {
            this.config = config;
        }
        public string show { get; set; }
        public void OnGet()
        {
            show = config["Message"];
        }

    }
}
