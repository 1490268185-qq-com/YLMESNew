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
    
    public partial class PM_MaterialList
    {
        public int ID { get; set; }
        public Nullable<int> ProjectID { get; set; }
        public Nullable<int> POID { get; set; }
        public Nullable<int> MaterialID { get; set; }
        public Nullable<int> InPCS { get; set; }
        public Nullable<int> InQTY { get; set; }
        public Nullable<int> IQC_Result { get; set; }
        public Nullable<int> IQCPassQTY { get; set; }
        public Nullable<int> PutOnPCS { get; set; }
        public Nullable<int> PutOnQTY { get; set; }
        public Nullable<int> OutPCS { get; set; }
        public Nullable<int> OutQTY { get; set; }
        public Nullable<int> PickPCS { get; set; }
        public Nullable<int> StockPCS { get; set; }
        public Nullable<int> StockQTY { get; set; }
        public string Units { get; set; }
        public string Location { get; set; }
        public string Status { get; set; }
        public string CreatedTime { get; set; }
        public string CreatedBy { get; set; }
        public string figureNumber { get; set; }
    }
}
