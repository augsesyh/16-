//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Goods
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Goods()
        {
            this.Goods_Assess = new HashSet<Goods_Assess>();
            this.Order_details = new HashSet<Order_details>();
            this.ShoppingCart = new HashSet<ShoppingCart>();
        }
    
        public int Goods_id { get; set; }
        public string Goods_name { get; set; }
        public double Goods_price { get; set; }
        public string Goods_intro { get; set; }
        public string Goods_photo { get; set; }
        public Nullable<int> Video_id { get; set; }
        public Nullable<int> Goods_Cate_id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Goods_Assess> Goods_Assess { get; set; }
        public virtual Goods_Cate Goods_Cate { get; set; }
        public virtual Video Video { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order_details> Order_details { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShoppingCart> ShoppingCart { get; set; }
    }
}
