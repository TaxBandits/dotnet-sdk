using System.Runtime.Serialization;

namespace Form1099NecSDK.Models.StateRecon
{
    [DataContract]
    public class NECStateRecon
    {
        [DataMember]
        public WestVirginiaRecon WV { get; set; }
        [DataMember]
        public AlabamaRecon AL { get; set; }

    }
}
