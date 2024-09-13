using System.Runtime.Serialization;

namespace Form941SDK.Models.Form941Create
{
    [DataContract]
    public class SignatureDetails
    {
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string SignatureType { get; set; }

        /// <summary>
        /// A 10 digit PIN received from the IRS. 
        /// </summary>
        [DataMember]
        public OnlineSignaturePIN OnlineSignaturePIN { get; set; }

        /// <summary>
        /// Reporting Agent PIN (5 Digits)
        /// </summary>
        [DataMember]
        public ReportingAgentPIN ReportingAgentPIN { get; set; }

        /// <summary>
        /// ERO PIN (5 Digits)
        /// </summary>
        [DataMember]
        public TaxPayerPIN TaxPayerPIN { get; set; }

        /// <summary>
        /// Alternative method to sign the Form. (If there is no Online Signature PIN)
        /// </summary>
        [DataMember]
        public Form8453Emp Form8453EMP { get; set; }

    }
}
