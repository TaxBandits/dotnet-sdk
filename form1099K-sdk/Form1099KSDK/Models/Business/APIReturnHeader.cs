using System.Runtime.Serialization;

namespace Form1099KSDK.Models.Business
{
    [DataContract]
    public class APIReturnHeader
    {
        [DataMember]
        public Business Business { get; set; }
    }
}
