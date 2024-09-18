using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Form941SDK.Models.Form941Create
{
    public class Form941Data
    {
       
        [DataMember]
        public int EmployeeCnt { get; set; }
        [DataMember]
        public decimal WagesAmt { get; set; }
        [DataMember]
        public decimal FedIncomeTaxWHAmt { get; set; }
        [DataMember]
        public bool? WagesNotSubjToSSMedcrTaxInd { get; set; }
        [JsonIgnore]
        public bool WagesNotSubjToSSMedcrTaxIndNullable { get { return WagesNotSubjToSSMedcrTaxInd ?? false; } set { WagesNotSubjToSSMedcrTaxInd = value; } }
        [DataMember]
        [JsonProperty(PropertyName = "SocialSecurityTaxCashWagesAmt_Col1")]
        public decimal Line5aInitialAmt { get; set; }
        [DataMember]
        [JsonProperty(PropertyName = "TaxableSocSecTipsAmt_Col1")]
        public decimal Line5bInitialAmt { get; set; }
        [DataMember]
        [JsonProperty(PropertyName = "TaxableMedicareWagesTipsAmt_Col1")]
        public decimal Line5cInitialAmt { get; set; }
        [DataMember]
        [JsonProperty(PropertyName = "TxblWageTipsSubjAddnlMedcrAmt_Col1")]
        public decimal Line5dInitialAmt { get; set; }
        [DataMember]
        [JsonProperty(PropertyName = "SocialSecurityTaxAmt_Col2")]
        public decimal Line5a { get; set; }
   
        [DataMember]
        [JsonProperty(PropertyName = "TaxOnSocialSecurityTipsAmt_Col2")]
        public decimal Line5b { get; set; }
        [DataMember]
        [JsonProperty(PropertyName = "TaxOnMedicareWagesTipsAmt_Col2")]
        public decimal Line5c { get; set; }
        [DataMember]
        [JsonProperty(PropertyName = "TaxOnWageTipsSubjAddnlMedcrAmt_Col2")]
        public decimal Line5d { get; set; }
        [DataMember]
        [JsonProperty(PropertyName = "TotSSMdcrTaxAmt")]
        public decimal Line5e { get; set; }
        [DataMember]
        public decimal TaxOnUnreportedTips3121qAmt { get; set; }
        [DataMember]
        [JsonProperty(PropertyName = "TotalTaxBeforeAdjustmentAmt")]
        public decimal Line6 { get; set; }
        [DataMember]
        public decimal CurrentQtrFractionsCentsAmt { get; set; }
        [DataMember]
        public decimal CurrentQuarterSickPaymentAmt { get; set; }
        [DataMember]
        public decimal CurrQtrTipGrpTermLifeInsAdjAmt { get; set; }
        [DataMember]
        [JsonProperty(PropertyName = "TotalTaxAfterAdjustmentAmt")]
        public decimal Line10 { get; set; }
        [DataMember]
        [JsonProperty(PropertyName = "PayrollTaxCreditAmt")]
        public decimal Line11 { get; set; }
        [DataMember]
        public bool IsPayrollTaxCredit { get; set; }
        [DataMember]
        public Form8974 Form8974 { get; set; }
       
        [DataMember]
        [JsonProperty(PropertyName = "TotTaxAfterAdjustmentAndNonRfdCr")]
        public decimal Line12 { get; set; }
        [DataMember]
        public decimal TotTaxDepositAmt { get; set; }
       
        [DataMember]
        [JsonProperty(PropertyName = "BalanceDueAmt")]
        public decimal Line14 { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "OverpaidAmt")]
        public decimal Line15 { get; set; }
        [DataMember]
        public string OverPaymentRecoveryType { get; set; }
    }
}
