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
    
    public partial class User_Menus_Quanxian_T
    {
        public int Guanxi_ID { get; set; }
        public Nullable<long> Menus_ID { get; set; }
        public Nullable<long> User_ID { get; set; }
    
        public virtual Menus_User_T Menus_User_T { get; set; }
        public virtual User_Information_T User_Information_T { get; set; }
    }
}
