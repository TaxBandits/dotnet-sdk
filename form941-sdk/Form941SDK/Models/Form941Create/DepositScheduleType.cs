using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Form941SDK.Models.Form941Create
{
    [DataContract]
    public class DepositScheduleType
    {
        /// <summary>
        /// Depositor Schedule Type
        /// </summary>
        [DataMember]
        //[Required(ErrorMessage = "ERR-DEPOSITORTYPE-01:Form 941, Part 2 Deposite Schedule Type is Required")]
        public string DepositorType { get; set; }

        /// <summary>
        /// Line 16, Option 2. Monthly Schedule Depositor
        /// </summary>
        [DataMember]
        public MonthlyDepositor MonthlyDepositor { get; set; }

        /// <summary>
        /// Line 16, Option 3. SemiWeekly Depositor
        /// </summary>
        [DataMember]
        public SemiWeeklyDepositor SemiWeeklyDepositor { get; set; }

        /// <summary>
        /// TotalQuarterTaxLiabilityAmt
        /// </summary>
        [DataMember]
        [JsonProperty(PropertyName = "TotalQuarterTaxLiabilityAmt")]
        public decimal TaxLiabilityTotalAmt { get; set; }
    }
    [DataContract]
    public class MonthlyDepositor
    {
        /// <summary>
        /// Tax Liability for Month 1 of the filing quarter
        /// </summary>
        [DataMember]
        public decimal TaxLiabilityMonth1 { get; set; }

        /// <summary>
        /// Tax Liability for Month 2 of the filing quarter
        /// </summary>
        [DataMember]
        public decimal TaxLiabilityMonth2 { get; set; }

        /// <summary>
        /// Tax Liability for Month 3 of the filing quarter
        /// </summary>
        [DataMember]
        public decimal TaxLiabilityMonth3 { get; set; }
    }
    [DataContract]
    public class SemiWeeklyDepositor
    {
        /// <summary>
        /// Schedule B: Tax Liability for Month 1 of the filing quarter
        /// </summary>
        [DataMember]
        public List<Form941ScheduleBMonth> ScheduleBMonth1Amt { get; set; }
        /// <summary>
        /// Schedule B: Tax Liability for Month 2 of the filing quarter
        /// </summary>
        [DataMember]
        public List<Form941ScheduleBMonth> ScheduleBMonth2Amt { get; set; }

        /// <summary>
        /// Schedule B: Tax Liability for Month 3 of the filing quarter
        /// </summary>
        [DataMember]
        public List<Form941ScheduleBMonth> ScheduleBMonth3Amt { get; set; }
    }
    [DataContract]
    public class Form941ScheduleBMonth
    {
        /// <summary>
        /// Tax Lability Day of the month 
        /// </summary>
        [DataMember]
        public DayOfMonth Day { get; set; }
        /// <summary>
        /// Tax Liability Amount
        /// </summary>
        [DataMember]
        //[PosNumberNoZero(ErrorMessage = "ERR-FORM941SCHEDULEBAMT-02:Form941 ScheduleB Amount must be a positive number, Do not enter negative value")]
        public decimal Amt { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public enum DayOfMonth
    {
        Day1 = 01,
        Day2 = 02,
        Day3 = 03,
        Day4 = 04,
        Day5 = 05,
        Day6 = 06,
        Day7 = 07,
        Day8 = 08,
        Day9 = 09,
        Day10 = 10,
        Day11 = 11,
        Day12 = 12,
        Day13 = 13,
        Day14 = 14,
        Day15 = 15,
        Day16 = 16,
        Day17 = 17,
        Day18 = 18,
        Day19 = 19,
        Day20 = 20,
        Day21 = 21,
        Day22 = 22,
        Day23 = 23,
        Day24 = 24,
        Day25 = 25,
        Day26 = 26,
        Day27 = 27,
        Day28 = 28,
        Day29 = 29,
        Day30 = 30,
        Day31 = 31
    }
}
