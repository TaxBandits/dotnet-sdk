using System.Runtime.Serialization;

namespace Form941SDK.Models.Form941Create
{
    [DataContract]
    public class ThirdPartyDesignee
    {

        /// <summary>
        /// Name of the Third Party Designee
        /// </summary>
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        /// Phone Number of the Third Party Designee
        /// </summary>
        [DataMember]
        public string Phone { get; set; }

        /// <summary>
        /// Any 5 digit PIN (Should not contain all zeroes)
        /// </summary>
        [DataMember]
        public string PIN { get; set; }
    }
}
