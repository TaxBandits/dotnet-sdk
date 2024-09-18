using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Form941SDK.Models.Form941Create
{
    [DataContract]
    public class Form8974
    {
        [DataMember]
        public List<Form8974IncomeTaxDetails> Form8974IncomeTaxDetails { get; set; }
       

        /// <summary>
        /// Form 8974, Part 2 Line 7 Enter the amount from Part 1, line 6(g)
        /// </summary>
        [DataMember]
        public decimal Line7 { get; set; }

        /// <summary>
        /// Form 8974, Part 2 Line 8 Enter the amount from Form 941 (941-PR or 941-SS), line 5a, Column 2; Form 943 (943-PR), line 3; or Form 944 (944(SP)), line 4a, Column 2
        /// </summary>
        [DataMember]
        public Nullable<decimal> Line8 { get; set; }

        /// <summary>
        /// Form 8974, Part 2 Line 9 Enter the amount from Form 941 (941-PR or 941-SS), line 5b, Column 2; or Form 944 (944(SP)), line 4b, Column 2
        /// </summary>
        [DataMember]
        public Nullable<decimal> Line9 { get; set; }

        /// <summary>
        /// Form 8974, Part 2 Line 10 Add lines 8 and 9
        /// </summary>
        [DataMember]
        public Nullable<decimal> Line10 { get; set; }

        /// <summary>
        /// Form 8974, Part 2 Line 11 Multiply line 10 by 50% (0.50). Check this box if you're a third-party payer of sick pay or check this box if you received a Section 3121(q) Notice and Demand. See the instructions before completing line 11
        /// </summary>
        [DataMember]
        public Nullable<decimal> Line11 { get; set; }

        /// <summary>
        /// Third-party payer of sick pay or you received a Section 3121(q) Notice and Demand
        /// </summary>
        [DataMember]
        public string PayerIndicatorType { get; set; }

        /// <summary> Credit against the employer share of social security tax. Enter the smaller of line 7 or 11, but not more than $250,000
        /// </summary>
        [DataMember]
        public decimal Line12 { get; set; }
        //Subtract line 12 from line 7
        [DataMember]
        public decimal Line13 { get; set; }
        //Enter the amount from Form 941 (941-PR or 941-SS),line 5c
        [DataMember]
        public decimal Line14 { get; set; }
        //Multiply line 14 by 50% (0.50). If you’re a third-party payer of sick pay or you received a Section 3121(q) Notice and Demand, see the instructions before completing line 15
        [DataMember]
        public decimal Line15 { get; set; }
        [DataMember]
        //Credit against the employer share of Medicare tax. Enter the smaller of line 13 or 15
        public decimal Line16 { get; set; }
        //Total credit. Add lines 12 and 16. Also, enter this amount on Form 941 (941-PR or 941-SS),line 11a;
        [DataMember]
        public decimal Line17 { get; set; }
    }


    [DataContract]
    public class Form8974IncomeTaxDetails
    {

        /// <summary>
        /// Form 8974, Part 1 Coulmn (a) Ending date of income tax period
        /// </summary>
        [DataMember]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public string IncomeTaxPeriodEndDate { get; set; }

        /// <summary>
        /// Form 8974, Part 1 (b) Income tax return filed that included Form 6765
        /// </summary>
        [DataMember]
        public string IncomeTaxReturnFiledForm { get; set; }

        /// <summary>
        /// Form 8974, Part 1 (c) Date income tax return was filed
        /// </summary>
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        [DataMember]
        public string IncomeTaxReturnFiledDate { get; set; }

        /// <summary>
        /// Form 8974, Part 1 (d) EIN  used on Form 6765 amount from Form 6765, line 44, or if applicable, the amount that was allocated to your EIN
        /// </summary>
        [DataMember]
        //[RegularExpression(@"^\d{9}$", ErrorMessage = "ERR-EIN-02:Enter Valid EIN")]
        public string Form6765EIN { get; set; }

        /// <summary>
        /// Form 8974, Part 1 (f) Amount of credit from column (e) taken on a previous period(s)
        /// </summary>
        [DataMember]
        //[Range(0, 99999999999999999.99, ErrorMessage = "ERR-FORM-6765-LINE44AMT-02:Form 8974," + "'Amount from Form 6765'" + "is required can only have a maximum of 17 digits including decimals & Enter only 2 digits after decimal")]
        //[RegularExpression(@"^(0|-?\d{0,15}(\.\d{0,2})?)$", ErrorMessage = "ERR-FORM-6765-LINE44AMT-02: Form 8974, 'Amount from Form 6765' can only have a maximum of 20 digits including decimals")]
        //[PosNumberNoZero(ErrorMessage = "ERR-FORM-6765-LINE44AMT-02: Form 8974, 'Amount from Form 6765' can only have positive values")]
        public decimal Form6765Line44Amt { get; set; }

        /// <summary>
        /// Form 8974, Part 1 (g) Remaining credit (subtract column (f) from column (e))
        /// </summary>
        [DataMember]
        //[Range(0, 99999999999999999.99, ErrorMessage = "ERR-PREVIOUS-PERIOD-REMAIN-CREDITAMT-01:Maximum 20 characters only allowed including decimals")]
        //[RegularExpression(@"^(0|-?\d{0,15}(\.\d{0,2})?)$", ErrorMessage = "ERR-PREVIOUS-PERIOD-REMAIN-CREDITAMT-01: Form 8974, Line 1(f) 'Previous Period Remaing Credit Amount'  can only have a maximum of 20 digits including decimals")]
        //[PosNumberNoZero(ErrorMessage = "ERR-PREVIOUS-PERIOD-REMAIN-CREDITAMT-01: Form 8974, Line 1(f) 'Previous Period Remaing Credit Amount' can only have positive values")]
        public decimal PreviousPeriodRemainingCreditAmt { get; set; }

        /// <summary>
        /// Form 8974, Part 1 Line 6 Add lines 1(g) through 5(g) and enter the total here
        /// </summary>
        [DataMember]
        public decimal RemainingCredit { get; set; }



    }

    [DataContract]
    public class Form8974FromTY2022
    {
        [DataMember]
        public List<Form8974IncomeTaxDetailsFromTY2022> Form8974IncomeTaxDetails { get; set; }


        /// <summary>
        /// Form 8974, Part 2 Line 7 Enter the amount from Part 1, line 6(g)
        /// </summary>
        [DataMember]
        public string Line7 { get; set; }

        /// <summary>
        /// Form 8974, Part 2 Line 8 Enter the amount from Form 941 (941-PR or 941-SS), line 5a, Column 2; Form 943 (943-PR), line 3; or Form 944 (944(SP)), line 4a, Column 2
        /// </summary>
        [DataMember]
        public string Line8 { get; set; }

        /// <summary>
        /// Form 8974, Part 2 Line 9 Enter the amount from Form 941 (941-PR or 941-SS), line 5b, Column 2; or Form 944 (944(SP)), line 4b, Column 2
        /// </summary>
        [DataMember]
        public string Line9 { get; set; }

        /// <summary>
        /// Form 8974, Part 2 Line 10 Add lines 8 and 9
        /// </summary>
        [DataMember]
        public string Line10 { get; set; }

        /// <summary>
        /// Form 8974, Part 2 Line 11 Multiply line 10 by 50% (0.50). Check this box if you're a third-party payer of sick pay or check this box if you received a Section 3121(q) Notice and Demand. See the instructions before completing line 11
        /// </summary>
        [DataMember]
        public string Line11 { get; set; }

        /// <summary>
        /// Third-party payer of sick pay or you received a Section 3121(q) Notice and Demand
        /// </summary>
        [DataMember]
        public string PayerIndicatorType { get; set; }

        /// <summary>
        /// Form 8974, Part 2 Line 12 Credit. Enter the smaller of line 7 or line 11. Also enter this amount on Form 941 (941-PR or 941-SS), line 11; Form 943 (943-PR), line 12; or Form 944 (944(SP)), line 8
        /// </summary>
        [DataMember]
        public string Line12 { get; set; }
    }

    [DataContract]
    public class Form8974IncomeTaxDetailsFromTY2022
    {


        /// <summary>
        /// Form 8974, Part 1 Coulmn (a) Ending date of income tax period
        /// </summary>
        [DataMember]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public string IncomeTaxPeriodEndDate { get; set; }

        /// <summary>
        /// Form 8974, Part 1 (b) Income tax return filed that included Form 6765
        /// </summary>
        [DataMember]
        public string IncomeTaxReturnFiledForm { get; set; }

        /// <summary>
        /// Form 8974, Part 1 (c) Date income tax return was filed
        /// </summary>
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        [DataMember]
        public string IncomeTaxReturnFiledDate { get; set; }

        /// <summary>
        /// Form 8974, Part 1 (d) EIN  used on Form 6765 amount from Form 6765, line 44, or if applicable, the amount that was allocated to your EIN
        /// </summary>
        [DataMember]
        //[RegularExpression(@"^\d{9}$", ErrorMessage = "ERR-EIN-02:Enter Valid EIN")]
  
        public string Form6765EIN { get; set; }

        /// <summary>
        /// Form 8974, Part 1 (f) Amount of credit from column (e) taken on a previous period(s)
        /// </summary>
        [DataMember]
        //[Range(0, 99999999999999999.99, ErrorMessage = "ERR-FORM-6765-LINE44AMT-02:Form 8974," + "'Amount from Form 6765'" + "is required can only have a maximum of 17 digits including decimals & Enter only 2 digits after decimal")]
        //[RegularExpression(@"^(0|-?\d{0,15}(\.\d{0,2})?)$", ErrorMessage = "ERR-FORM-6765-LINE44AMT-02: Form 8974, 'Amount from Form 6765' can only have a maximum of 20 digits including decimals")]
        //[PosNumberNoZero(ErrorMessage = "ERR-FORM-6765-LINE44AMT-02: Form 8974, 'Amount from Form 6765' can only have positive values")]
        public string Form6765Line44Amt { get; set; }

        /// <summary>
        /// Form 8974, Part 1 (g) Remaining credit (subtract column (f) from column (e))
        /// </summary>
        [DataMember]
        //[Range(0, 99999999999999999.99, ErrorMessage = "ERR-PREVIOUS-PERIOD-REMAIN-CREDITAMT-01:Maximum 20 characters only allowed including decimals")]
        //[RegularExpression(@"^(0|-?\d{0,15}(\.\d{0,2})?)$", ErrorMessage = "ERR-PREVIOUS-PERIOD-REMAIN-CREDITAMT-01: Form 8974, Line 1(f) 'Previous Period Remaing Credit Amount'  can only have a maximum of 20 digits including decimals")]
        //[PosNumberNoZero(ErrorMessage = "ERR-PREVIOUS-PERIOD-REMAIN-CREDITAMT-01: Form 8974, Line 1(f) 'Previous Period Remaing Credit Amount' can only have positive values")]
        public string PreviousPeriodRemainingCreditAmt { get; set; }

        /// <summary>
        /// Form 8974, Part 1 Line 6 Add lines 1(g) through 5(g) and enter the total here
        /// </summary>
        [DataMember]
        public string RemainingCredit { get; set; }



    }
}
