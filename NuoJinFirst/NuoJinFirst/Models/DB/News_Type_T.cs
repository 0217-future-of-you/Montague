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
    
    public partial class News_Type_T
    {
        public News_Type_T()
        {
            this.News_T = new HashSet<News_T>();
        }
    
        public long News_Type_ID { get; set; }
        public string News_Type_Name { get; set; }
    
        public virtual ICollection<News_T> News_T { get; set; }
    }
}
