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
    
    public partial class PM_Figure
    {
        public int ID { get; set; }
        public string FigureNumber { get; set; }
        public string FolderName { get; set; }
        public string FileName { get; set; }
        public byte[] Picture { get; set; }
        public string note { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedTime { get; set; }
    }
}
