//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyApp.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class address
    {
        public address()
        {
            this.employee = new HashSet<employee>();
        }
    
        public int Id { get; set; }
        public string state { get; set; }
        public Nullable<int> city { get; set; }
    
        public virtual ICollection<employee> employee { get; set; }
    }
}
