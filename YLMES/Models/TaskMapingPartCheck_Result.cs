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
    
    public partial class TaskMapingPartCheck_Result
    {
        public int 序号 { get; set; }
        public string 工件编码 { get; set; }
        public int 子件序号 { get; set; }
        public string 子件编码 { get; set; }
        public string 子件规格 { get; set; }
        public Nullable<int> 子件数量 { get; set; }
        public Nullable<int> 原材料用量 { get; set; }
        public string 原材料单位 { get; set; }
        public string 子BOM { get; set; }
        public Nullable<int> 是否组装件 { get; set; }
        public string 工艺流程 { get; set; }
    }
}
