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
    
    public partial class Payment
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string TransactionNo { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public int Mode { get; set; }
        public Nullable<System.DateTime> PaymentDate { get; set; }
        public string NameOnCard { get; set; }
        public string CardNumber { get; set; }
        public Nullable<int> IsActive { get; set; }
        public Nullable<decimal> TrnChrg { get; set; }
        public Nullable<decimal> DeliveryChrg { get; set; }
        public string Bank { get; set; }
        public string Branch { get; set; }
        public string ChequeNo { get; set; }
        public string Comments { get; set; }
        public Nullable<decimal> GSTCharges { get; set; }
        public Nullable<decimal> Discount { get; set; }
    }
}
