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
    
    public partial class PM_WorkStationDetail
    {
        public int ID { get; set; }
        public Nullable<int> StationID { get; set; }
        public Nullable<int> WorkOrderID { get; set; }
        public Nullable<int> RecievedPCS { get; set; }
        public Nullable<int> CompletedPCS { get; set; }
        public Nullable<int> FailedPCS { get; set; }
        public Nullable<int> TrasferNextStationPCS { get; set; }
        public string StartWorkTime { get; set; }
        public string EndWorkTime { get; set; }
        public Nullable<double> WorkHours { get; set; }
        public Nullable<int> EmployeeID { get; set; }
        public Nullable<int> QAEmployeeID { get; set; }
        public string StatusID { get; set; }
    }
}