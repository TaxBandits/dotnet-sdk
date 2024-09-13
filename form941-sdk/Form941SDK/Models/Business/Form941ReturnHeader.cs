using Form941SDK.Models.Form941Create;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Form941SDK.Models.Business
{
    [DataContract]
    public class Form941ReturnHeader
    {
        /// <summary>
        /// Return type. The form types can be FORM941, FORM941PR, or FORM941SS.
        /// </summary>
        [DataMember]
        //[Required(ErrorMessage = "ERR-RETURNTYPE-01:Return Type is Required")]
        //[MaxLength(15, ErrorMessage = "ERR-RETURNTYPE-02:Maximum 15 characters only allowed")]
        public string ReturnType { get; set; }

        /// <summary>
        /// Maximum of 1000 clients can be sent in one submission. If there are more than 1000 Clients for Schedule R, the submissions have to be multiple with the value "True". The submission with the final list of clients should have the value "False"
        /// </summary>

        [DataMember]
        public bool MoreClients { get; set; }


        /// <summary>
        ///  Form 941 Tax Year
        /// </summary>
        [DataMember]
        public string TaxYr { get; set; }

        /// <summary>
        /// Form 941 Filing Quarter 
        /// </summary>
        [DataMember]
        //[Required(ErrorMessage = "ERR-QUARTER-01:Filling Quarter is Required")]
        //[MaxLength(2, ErrorMessage = "ERR-QUARTER-02:Denote the Filing Quarter in 2 characters only")]
        //[RegularExpression("([Q|q][1-4]+$)", ErrorMessage = "ERR-QUARTER-04:Enter a valid Form 941 Filing Quarter")]
        public string Qtr { get; set; }

        /// <summary>
        /// Business Details
        /// </summary>
        [DataMember]
        public Business Business { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public bool IsThirdPartyDesignee { get; set; }

        /// <summary>
        /// Third Party Designee Details
        /// </summary>
        [DataMember]
        public ThirdPartyDesignee ThirdPartyDesignee { get; set; }

        /// <summary>
        /// Online Signature PIN or Reporting Agent PIN 
        /// </summary>
        [DataMember]
        public SignatureDetails SignatureDetails { get; set; }

        /// <summary>
        /// Business Status Details
        /// </summary>
        [DataMember]
        public BusinessStatusDetails BusinessStatusDetails { get; set; }
        /// <summary>
        /// 
        /// </summary>



    
    }
}
