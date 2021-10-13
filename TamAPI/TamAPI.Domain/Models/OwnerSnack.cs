using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TamAPI.Models
{
    public class OwnerSnack
    {
        public Guid ownersnack_id { get; set; }
        public Guid snack_id { get; set; }
        public Guid owner_id { get; set; }
        public int snack_quantity { get; set; }

    }
}