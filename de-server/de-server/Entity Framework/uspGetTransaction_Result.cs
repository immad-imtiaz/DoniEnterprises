//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace de_server.Entity_Framework
{
    using System;
    
    public partial class uspGetTransaction_Result
    {
        public long tr_transactionID { get; set; }
        public Nullable<System.DateTime> tr_date { get; set; }
        public Nullable<long> tr_bpBuyerID { get; set; }
        public Nullable<long> tr_bpSellerID { get; set; }
        public Nullable<int> tr_productID { get; set; }
        public string tr_origin { get; set; }
        public Nullable<int> tr_quantity { get; set; }
        public int tr_price { get; set; }
        public string tr_packing { get; set; }
        public Nullable<System.DateTime> tr_shipment_start { get; set; }
        public Nullable<System.DateTime> tr_shipment_end { get; set; }
        public string tr_fileID { get; set; }
        public string tr_contractID { get; set; }
        public string tr_other_info { get; set; }
        public int tr_createdBy { get; set; }
        public Nullable<System.DateTime> tr_createdOn { get; set; }
        public Nullable<int> tr_editedBy { get; set; }
        public Nullable<System.DateTime> tr_editedOn { get; set; }
    }
}
