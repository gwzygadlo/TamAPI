using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TamAPI.Models
{
    public class Health
    {
        public Guid health_id { get; set; }
        public string health_name { get; set; }
        public int health_scale { get; set; }


    }
}