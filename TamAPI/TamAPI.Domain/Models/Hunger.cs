using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TamAPI.Models
{
    public class Hunger
    {
        public Guid hunger_id { get; set; }
        public string hunger_name { get; set; }
        public int hunger_scale { get; set; }


    }
}