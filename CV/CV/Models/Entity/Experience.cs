//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CV.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Experience
    {
        public int ID { get; set; }
        public string POSITION { get; set; }
        public string COMPANY { get; set; }
        public string SECTOR { get; set; }
        public Nullable<System.DateTime> START { get; set; }
        public Nullable<System.DateTime> FINISH { get; set; }
        public string WAYOFWORKING { get; set; }
    }
}