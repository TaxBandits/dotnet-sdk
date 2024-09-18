using System.Runtime.Serialization;

namespace Form941SDK.Models.Form941Create
{
    [DataContract]
    public class ReportingAgentPIN
    {
        /// <summary>
        /// Reporting Agent PIN (5 Digits)
        /// </summary>
        [DataMember]
        public string PIN { get; set; }
    }
    [DataContract]
    public class TaxPayerPIN
    {
        /// <summary>
        /// A 5 digit PIN. 
        /// </summary>
        [DataMember]
        public string PIN { get; set; }
    }
}
