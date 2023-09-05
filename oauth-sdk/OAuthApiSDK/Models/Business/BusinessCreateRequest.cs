using System.Net;
using System.Runtime.Serialization;

namespace OAuthApiSDK.Models.Business
{
    public class BusinessCreateRequest
    {
        [DataMember]
        public Guid? BusinessId { get; set; }

        [DataMember]
        public string PayerRef { get; set; }

        /// <summary>
        /// Name of the Business you want to create a return.
        /// </summary>
        [DataMember]
        public string BusinessNm { get; set; }

        /// <summary>
        /// Trade Name (DBA) of the business. This is optional.
        /// </summary>
        [DataMember]
        public string TradeNm { get; set; }

        [DataMember]
        public bool IsEIN { get; set; }

        /// <summary>
        /// Employer Identification Number or Social Security Number
        /// </summary>
        [DataMember]
        public string EINorSSN { get; set; }

        /// <summary>
        /// Employer's email address.
        /// </summary>
        [DataMember]
        public string Email { get; set; }

        /// <summary>
        /// Name of a person who could be contacted by the IRS if needed.
        /// </summary>
        [DataMember]
        public string ContactNm { get; set; }


        /// <summary>
        /// Employer's phone number, including the area code.
        /// </summary>
        [DataMember]
        public string Phone { get; set; }

        /// <summary>
        /// Phone extension number. Optional.
        /// </summary>
        [DataMember]
        public string PhoneExtn { get; set; }

        /// <summary>
        /// Employer's Fax number. Optional.
        /// </summary>
        [DataMember]
        public string Fax { get; set; }

        /// <summary>
        /// Type of business entity. The value must be ESTE, PART, CORP, EORG, SPRO. Optional for W2/1099 and required for Form 94x.
        /// </summary>
        [DataMember]
        public string BusinessType { get; set; }

        /// <summary>
        /// Authorized person information to sign the return. Optional for W2/1099 and required for Form 94x.
        /// </summary>
        [DataMember]
        public SigningAuthority SigningAuthority { get; set; }

        public string KindOfEmployer { get; set; }

        /// <summary>
        /// Kind Of Payer based on the Employer's Federal Tax Return. The value must be REGULAR941, REGULAR944, AGRICULTURAL943, HOUSEHOLD, MILITARY, MEDICAREQUALGOVEM, RAILROADFORMCT1. Required only for Form W-2 filing
        /// </summary>
        [DataMember]
        public string KindOfPayer { get; set; }

        [DataMember]
        public bool IsBusinessTerminated { get; set; }

        [DataMember]
        public bool? IsForeign { get; set; }

        [DataMember]
        public USAddress USAddress { get; set; }

        [DataMember]
        public ForeignAddress ForeignAddress { get; set; }

    }
    public class SigningAuthority
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string BusinessMemberType { get; set; }
    }
    public class USAddress
    {
        /// <summary>
        /// Employer/Payer address (street address or post office box for the employer/payer).
        /// </summary>
        public string Address1 { get; set; }
        /// <summary>
        /// The suite, apartment, number of the employer/payer, if applicable. This is optional.
        /// </summary>
        public string Address2 { get; set; }
        /// <summary>
        /// Employer/Payer city.
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// State code of the employer/payer. Refer Static values.
        /// </summary>
        public string State { get; set; }
        /// <summary>
        /// Employer/Payer ZIP Code.
        /// </summary>       
        public string ZipCd { get; set; }
    }
    public class ForeignAddress
    {
        /// <summary>
        /// Employer/Payer address (street address or post office box for the employer/payer).
        /// </summary>

        public string Address1 { get; set; }

        /// <summary>
        /// The suite, apartment, number of the employer/payer, if applicable. This is optional.
        /// </summary>

        public string Address2 { get; set; }

        /// <summary>
        /// Employer/Payer city.
        /// </summary>

        public string City { get; set; }

        /// <summary>
        /// Employer/Payer province or state Name
        /// </summary>

        public string ProvinceOrStateNm { get; set; }

        /// <summary>
        /// Employer/Payer country code
        /// </summary>

        public string Country { get; set; }

        /// <summary>
        /// Employer/Payer Postal code
        /// </summary>

        public string PostalCd { get; set; }
    }
}
