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
    
    public partial class Shop_Information_T
    {
        public long Shop_Information_Id { get; set; }
        public string Shop_Information_Name { get; set; }
        public Nullable<decimal> Shop_Information_Price { get; set; }
        public Nullable<decimal> Shop_Information_Discount { get; set; }
        public Nullable<int> Shop_Information_Count { get; set; }
        public Nullable<int> Shop_Information_Sell { get; set; }
        public string Shop_Information_Deciaml { get; set; }
        public Nullable<long> Shop_Type_Id { get; set; }
        public Nullable<long> Shop_Id { get; set; }
        public string Shop_Information_image { get; set; }
    
        public virtual db_Shop_Type_T db_Shop_Type_T { get; set; }
        public virtual Shop_T Shop_T { get; set; }
    }
}
