//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Online_SHopping_Cart.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order_Table
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order_Table()
        {
            this.OrderDetail_Table = new HashSet<OrderDetail_Table>();
        }
    
        public int OrderId { get; set; }
        public int Userid { get; set; }
        public string OrderDeliveryAddress { get; set; }
        public Nullable<System.DateTime> OrderDeliveryDate { get; set; }
        public int OrderStatus { get; set; }
        public Nullable<decimal> TotalAmount { get; set; }
        public string OrderCreatedBy { get; set; }
        public System.DateTime OrderCreatedDate { get; set; }
        public string OrderUpdatedBy { get; set; }
        public System.DateTime OrderUpdatedDate { get; set; }
        public bool OrderIsDeleted { get; set; }
        public string OrderNotification { get; set; }
    
        public virtual User_Table User_Table { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail_Table> OrderDetail_Table { get; set; }
    }
}