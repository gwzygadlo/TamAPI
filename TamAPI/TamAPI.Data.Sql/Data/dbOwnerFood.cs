//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TamAPI.Data.Sql.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class dbOwnerFood
    {
        public System.Guid ownerfood_id { get; set; }
        public System.Guid food_id { get; set; }
        public System.Guid owner_id { get; set; }
        public int food_quantity { get; set; }
    
        public virtual dbFood Food { get; set; }
        public virtual dbOwner Owner { get; set; }
    }
}