using Form941SDK.Models.Business;
using System.Runtime.Serialization;

namespace Form941SDK.Models.Form941Create
{
    #region Business Status Details
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class BusinessStatusDetails
    {
        /// <summary>
        /// Mark, if the business was closed o stopped paying wages
        /// </summary>
        [DataMember]
        public bool IsBusinessClosed { get; set; }

        /// <summary>
        /// Date on which the Buiness was closed and Record Keeper details
        /// </summary>
        [DataMember]
        public BusinessClosedDetails BusinessClosedDetails { get; set; }

        /// <summary>
        /// Mark, if the business was closed o stopped paying wages
        /// </summary>
        [DataMember]
        public bool IsBusinessTransferred { get; set; }

        /// <summary>
        /// Type of Transfer and Record Keeper details
        /// </summary>
        [DataMember]
        public BusinessTransferredDetails BusinessTransferredDetails { get; set; }

        /// <summary>
        /// Select If the return is for a seasonal employer and the employer don’t have to file a return for every quarter of the year 
        /// </summary>
        [DataMember]
        public bool IsSeasonalEmployer { get; set; }

    }
    #endregion
    #region BusinessClosed
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class BusinessClosedDetails
    {
        /// <summary>
        /// Name of the Record Keeper
        /// </summary>
        [DataMember]

        public string Name { get; set; }

        /// <summary>
        /// Final date the wages was last paid
        /// </summary>
        [DataMember]
        //  [DataType(DataType.DateTime, ErrorMessage = "Please fill in a valid date.")]
        // [RegularExpression(@"^\d{1,2}\/\d{1,2}\/\d{4}$", ErrorMessage = "Fill in a valid date1.")]
        public DateTime? FinalDateWagesPaid { get; set; }

        /// <summary>
        /// </summary>
        [DataMember]
        public bool IsForeign { get; set; }

        /// <summary>
        /// Address of the Record Keeper (US address)
        /// </summary>
        [DataMember]
        public USAddress USAddress { get; set; }

        /// <summary>
        /// Address of the Record Keeper (Foreign address)
        /// </summary>
        [DataMember]
        public ForeignAddress ForeignAddress { get; set; }


    }
    #endregion

    #region BusinessTransferred
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class BusinessTransferredDetails
    {
        /// <summary>
        /// Name of the Record Keeper
        /// </summary>
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        /// Type of Transfer (Sold or Transferred)
        /// </summary>
        [DataMember]
        public string BusinessChangeType { get; set; }

        /// <summary>
        /// Date of Sale / Transfer
        /// </summary>
        [DataMember]
        public DateTime? DateOfChange { get; set; }

        /// <summary>
        /// New Business Type of the transferred business 
        /// </summary>
        [DataMember]
        public string NewBusinessType { get; set; }

        /// <summary>
        /// New Business Name of the transferred business 
        /// </summary>
        [DataMember]
        public string NewBusinessName { get; set; }

        /// <summary>
        /// </summary>
        [DataMember]
        public bool IsForeign { get; set; }

        /// <summary>
        /// Address of the Record Keeper (US address)
        /// </summary>
        [DataMember]
        public USAddress USAddress { get; set; }

        /// <summary>
        /// Address of the Record Keeper (Foreign address)
        /// </summary>
        [DataMember]
        public ForeignAddress ForeignAddress { get; set; }
    }
    #endregion
}
