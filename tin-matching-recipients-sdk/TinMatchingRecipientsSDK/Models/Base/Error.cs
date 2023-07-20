using System.Runtime.Serialization;

namespace TinMatchingRecipientsSDK.Models.Base
{
    [DataContract]
    public class Error
    {

        /// <summary>
        /// It will return the validation error Id
        /// </summary>
        [DataMember]

        public string Id { get; set; }
        /// <summary>
        /// It will return the validation error code
        /// </summary>
        [DataMember]

        public string Code { get; set; }

        /// <summary>
        /// It will return the name of the validation error
        /// </summary>
        [DataMember]

        public string Name { get; set; }

        /// <summary>
        /// It will return the detailed message of the validation error
        /// </summary>
        [DataMember]

        public string Message { get; set; }

        /// <summary>
        /// It will show the type of an error
        /// </summary>
        [DataMember]

        public string Type { get; set; }
    }
}
