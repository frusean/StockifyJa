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
    
    public partial class Stock
    {
        public int StockID { get; set; }
        public Nullable<int> ProductID { get; set; }
        public Nullable<int> QuantityInStock { get; set; }
    
        public virtual Product Product { get; set; }
    }
}
