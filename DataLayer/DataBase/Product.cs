//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer.DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        public int ID { get; set; }
        public Nullable<int> CategoryID { get; set; }
        public string Slug { get; set; }
        public string Detail { get; set; }
        public Nullable<bool> Trending { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<double> NumberViews { get; set; }
        public Nullable<double> Price { get; set; }
        public string MetaKey { get; set; }
        public Nullable<System.DateTime> Create_at { get; set; }
        public Nullable<System.DateTime> Update_at { get; set; }
        public Nullable<System.DateTime> Delete_at { get; set; }
    }
}
