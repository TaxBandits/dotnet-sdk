using System.Runtime.Serialization;

namespace Form941SDK.Models.Form941Create
{
    [DataContract]
    public class OnlineSignaturePIN
    {
        /// <summary>
        /// A 10 digit PIN received from the IRS. 
        /// </summary>
        [DataMember]
        public string PIN { get; set; }

    }
}
