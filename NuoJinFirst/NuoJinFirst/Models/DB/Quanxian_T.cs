//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace NuoJinFirst.Models.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Quanxian_T
    {
        public long ID { get; set; }
        public Nullable<long> Menu_ID { get; set; }
        public Nullable<long> User_TyID { get; set; }
    
        public virtual User_Menu User_Menu { get; set; }
        public virtual User_Type_T User_Type_T { get; set; }
    }
}
