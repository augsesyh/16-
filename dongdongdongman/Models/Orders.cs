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
    
    public partial class Orders
    {
        public string Orders_id { get; set; }
        public string Address_id { get; set; }
        public string User_id { get; set; }
        public Nullable<System.DateTime> Orders_time { get; set; }
        public string Orders_mon { get; set; }
    
        public virtual Address Address { get; set; }
        public virtual User User { get; set; }
    }
}