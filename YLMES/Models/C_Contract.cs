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
    
    public partial class C_Contract
    {
        public int ID { get; set; }
        public string CustomerName { get; set; }
        public string ContractNumber { get; set; }
        public string DateOfSign { get; set; }
        public string Money { get; set; }
        public string AmountCollected { get; set; }
        public string PaymentMethod { get; set; }
        public string IfInstall { get; set; }
        public string IfTransport { get; set; }
        public string IfIncludeTax { get; set; }
        public string DeliveryTime { get; set; }
        public string ConditionsOfbreachOfContract { get; set; }
        public string Summary { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedTime { get; set; }
        public string StatusID { get; set; }
        public string AuditThrough { get; set; }
        public string IfPayment { get; set; }
        public string DepositAmount { get; set; }
        public string DeliveryAmount { get; set; }
        public string InstallationAmount { get; set; }
        public string AcceptanceAmount { get; set; }
        public string QualityAssuranceAmount { get; set; }
        public Nullable<int> CustomerId { get; set; }
        public string IsCustomer { get; set; }
        public string TaskLevel { get; set; }
    }
}
