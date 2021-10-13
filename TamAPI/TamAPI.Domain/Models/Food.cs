using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TamAPI.Models
{
    public class Food
    {
        public Guid food_id { get; set; }
        public string food_name { get; set; }
        public int cost { get; set; }


    }
}