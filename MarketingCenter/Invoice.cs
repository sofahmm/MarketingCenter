//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MarketingCenter
{
    using System;
    using System.Collections.Generic;
    
    public partial class Invoice
    {
        public int ID { get; set; }
        public Nullable<int> Buyer { get; set; }
        public Nullable<int> Vacation_price { get; set; }
        public Nullable<int> Quantity_of_goods_released { get; set; }
        public string Address { get; set; }
        public Nullable<int> Product { get; set; }
    
        public virtual Buyer Buyer1 { get; set; }
        public virtual Product Product1 { get; set; }
    }
}