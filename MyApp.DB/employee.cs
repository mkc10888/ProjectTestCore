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
    
    public partial class employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> AddressId { get; set; }
        public string EmailId { get; set; }
        public string PhoneNumber { get; set; }
    
        public virtual address address { get; set; }
    }
}