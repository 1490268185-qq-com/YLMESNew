//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace YLMES.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PM_ProductStation
    {
        public int ID { get; set; }
        public string Station { get; set; }
        public Nullable<int> StationTypeID { get; set; }
        public Nullable<int> LineID { get; set; }
        public string CreatedBY { get; set; }
        public string CreatedTime { get; set; }
        public string UpdatedBy { get; set; }
        public string UpdatedTime { get; set; }
        public string StatusID { get; set; }
    }
}
