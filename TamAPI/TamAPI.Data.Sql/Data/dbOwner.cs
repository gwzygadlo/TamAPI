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
    
    public partial class dbOwner
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public dbOwner()
        {
            this.OwnerFoods = new HashSet<dbOwnerFood>();
            this.OwnerSnacks = new HashSet<dbOwnerSnack>();
            this.Tamas = new HashSet<dbTama>();
        }
    
        public System.Guid owner_id { get; set; }
        public string owner_name { get; set; }
        public int owner_age { get; set; }
        public int owner_points { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dbOwnerFood> OwnerFoods { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dbOwnerSnack> OwnerSnacks { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dbTama> Tamas { get; set; }
    }
}
