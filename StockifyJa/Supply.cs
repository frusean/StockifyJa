//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StockifyJa
{
    using System;
    using System.Collections.Generic;
    
    public partial class Supply
    {
        public int SupplyID { get; set; }
        public Nullable<int> ProductID { get; set; }
        public Nullable<int> QuantityPurchased { get; set; }
        public Nullable<decimal> Cost { get; set; }
        public Nullable<System.DateTime> SupplyDate { get; set; }
    
        public virtual Product Product { get; set; }
    }
}
