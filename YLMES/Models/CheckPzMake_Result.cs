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
    
    public partial class CheckPzMake_Result
    {
        public int ID { get; set; }
        public string Make { get; set; }
        public string Name { get; set; }
        public Nullable<decimal> Debit { get; set; }
        public Nullable<decimal> Credit { get; set; }
        public string Number { get; set; }
        public Nullable<int> AppID { get; set; }
        public Nullable<int> PzID { get; set; }
    }
}
