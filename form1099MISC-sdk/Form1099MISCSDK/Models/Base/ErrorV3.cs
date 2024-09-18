using System.Runtime.Serialization;

namespace Form1099MISCSDK.Models.Base
{
    [DataContract]
    public class ErrorV3
    {
        [DataMember]
        public string Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Message { get; set; }
    }
}
