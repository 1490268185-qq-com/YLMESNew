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
    
    public partial class SP_Contract_ProductDetailNotice_Check_Result
    {
        public int ID { get; set; }
        public string 合同编号 { get; set; }
        public string 产品名称 { get; set; }
        public string 客户产品名称 { get; set; }
        public string 产品规格 { get; set; }
        public string 单位 { get; set; }
        public Nullable<decimal> 合同数量 { get; set; }
        public Nullable<int> InWH { get; set; }
        public Nullable<decimal> 已发货数量 { get; set; }
        public Nullable<int> QTY { get; set; }
        public string ShipNoticeNumber { get; set; }
        public string 创建人 { get; set; }
        public string 创建时间 { get; set; }
        public string 状态 { get; set; }
        public string StatusID { get; set; }
        public Nullable<int> 库存 { get; set; }
    }
}
