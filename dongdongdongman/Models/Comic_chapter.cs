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
    
    public partial class Comic_chapter
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Comic_chapter()
        {
            this.Comic_pager = new HashSet<Comic_pager>();
            this.Subscribe = new HashSet<Subscribe>();
        }
    
        public int Comic_chapter_id { get; set; }
        public Nullable<int> Comic_id { get; set; }
        public string Comic_chapter_detail { get; set; }
        public string Comic_chapter_title { get; set; }
        public Nullable<System.DateTime> Comic_update_time { get; set; }
        public Nullable<int> Comic_chapter_num { get; set; }
        public Nullable<int> Comic_fufei { get; set; }
    
        public virtual Comic Comic { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comic_pager> Comic_pager { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Subscribe> Subscribe { get; set; }
    }
}
