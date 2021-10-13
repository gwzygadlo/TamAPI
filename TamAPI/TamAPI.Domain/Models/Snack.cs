using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TamAPI.Models
{
    public class Snack
    {
        public Guid snack_id { get; set; }
        public string snack_name { get; set; }
        public int cost { get; set; }


    }
}