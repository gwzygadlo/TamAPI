using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TamAPI.Models
{
    public class Tama
    {
        public Guid tama_id { get; set; }
        public string tama_name { get; set; }
        public int tama_age { get; set; }
        public string tama_gender { get; set; }
        public string tama_type { get; set; }
        public Guid owner_id { get; set; }
        public Guid health_id { get; set; }
        public Guid hunger_id { get; set; }
        public Guid happiness_id { get; set; }

    }
}