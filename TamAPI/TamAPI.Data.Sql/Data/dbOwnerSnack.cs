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
    
    public partial class dbOwnerSnack
    {
        public System.Guid ownersnack_id { get; set; }
        public System.Guid snack_id { get; set; }
        public System.Guid owner_id { get; set; }
        public int snack_quantity { get; set; }
    
        public virtual dbSnack Snack { get; set; }
        public virtual dbOwner Owner { get; set; }
    }
}
