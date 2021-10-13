using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TamAPI.Models
{
    public class OwnerFood
    {
        public Guid ownerfood_id { get; set; }
        public Guid food_id { get; set; }
        public Guid owner_id { get; set; }
        public int food_quantity { get; set; }

    }
}