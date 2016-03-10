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
    using System.Collections.Generic;
    
    public partial class Product
    {
        public Product()
        {
            this.dailyProductPrices = new HashSet<dailyProductPrice>();
            this.Transactions = new HashSet<Transaction>();
            this.BusinessPartners = new HashSet<BusinessPartner>();
        }
    
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> LastUpdatedOn { get; set; }
        public Nullable<int> LastUpdatedBy { get; set; }
        public Nullable<int> moisture { get; set; }
        public Nullable<int> purity { get; set; }
        public Nullable<int> weaveled { get; set; }
        public string origin { get; set; }
        public Nullable<int> splits { get; set; }
        public string quality { get; set; }
        public Nullable<int> damaged { get; set; }
        public Nullable<int> foreignMatter { get; set; }
        public Nullable<int> greenDamaged { get; set; }
        public Nullable<int> otherColor { get; set; }
        public Nullable<int> wrinkled { get; set; }
    
        public virtual AppUser AppUser { get; set; }
        public virtual AppUser AppUser1 { get; set; }
        public virtual ICollection<dailyProductPrice> dailyProductPrices { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
        public virtual ICollection<BusinessPartner> BusinessPartners { get; set; }
    }
}
