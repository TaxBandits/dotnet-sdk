using System.Runtime.Serialization;

namespace Form1099NecSDK.Models.Business
{
    [DataContract]
    public class APIReturnHeader
    {
        [DataMember]
        public Business Business { get; set; }
    }
}
