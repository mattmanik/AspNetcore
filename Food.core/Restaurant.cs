using System;
using System.Collections.Generic;
using System.Text;

namespace Food.core
{
    public partial class Restaurant
    {

        public string Name { get; set; }
        public int ID
        {
            get; set;
        }
        public string Location { get; set; }

        public CuisineType cuisine
        {
            get; set;
        }
    }
}
