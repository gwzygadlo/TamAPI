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
    
    public partial class dbTama
    {
        public System.Guid tama_id { get; set; }
        public string tama_name { get; set; }
        public int tama_age { get; set; }
        public string tama_gender { get; set; }
        public string tama_type { get; set; }
        public System.Guid owner_id { get; set; }
        public System.Guid health_id { get; set; }
        public System.Guid hunger_id { get; set; }
        public System.Guid happiness_id { get; set; }
    
        public virtual dbHappiness Happiness { get; set; }
        public virtual dbHealth Health { get; set; }
        public virtual dbHunger Hunger { get; set; }
        public virtual dbOwner Owner { get; set; }
    }
}
