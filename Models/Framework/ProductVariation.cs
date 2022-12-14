//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductVariation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProductVariation()
        {
            this.ImportBillDetails = new HashSet<ImportBillDetail>();
            this.OrderDetails = new HashSet<OrderDetail>();
            this.Feedbacks = new HashSet<Feedback>();
        }
    
        public long ProVariationID { get; set; }
        public Nullable<long> ProId { get; set; }
        public Nullable<long> ProSizeID { get; set; }
        public Nullable<long> ProColorID { get; set; }
        public Nullable<int> Ordered { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<bool> Status { get; set; }
        public string DisplayImage { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ImportBillDetail> ImportBillDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ProductColor ProductColor { get; set; }
        public virtual ProductSize ProductSize { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Feedback> Feedbacks { get; set; }
        public virtual Product Product { get; set; }
    }
}
