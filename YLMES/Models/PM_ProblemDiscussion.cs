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
    
    public partial class PM_ProblemDiscussion
    {
        public int ID { get; set; }
        public string ProblemName { get; set; }
        public string Desc { get; set; }
        public string Solution { get; set; }
        public string Status { get; set; }
        public string CreatedBY { get; set; }
        public Nullable<System.DateTime> CreatedTime { get; set; }
        public string CompletedBy { get; set; }
        public Nullable<System.DateTime> CompletedTime { get; set; }
    }
}