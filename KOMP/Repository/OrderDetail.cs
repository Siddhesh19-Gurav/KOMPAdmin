//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KOMP.Repository
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderDetail
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int SubProductId { get; set; }
        public int Quantity { get; set; }
        public Nullable<System.DateTime> DeliverDate { get; set; }
        public Nullable<int> IsActive { get; set; }
        public Nullable<int> YourguyOrderId { get; set; }
    }
}
