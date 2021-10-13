using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TamAPI.Models
{
    public class Owner
    {
        public Guid owner_id { get; set; }
        public string owner_name { get; set; }
        public int owner_age { get; set; }
        public int owner_points { get; set; }

    }
}