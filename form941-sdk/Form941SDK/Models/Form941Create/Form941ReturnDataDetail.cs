using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using static Form941SDK.Models.Form941Create.IRSPayments;

namespace Form941SDK.Models.Form941Create
{
    [DataContract]
    public class Form941ReturnDataDetail
    {
        [DataMember]
        public Form941Data Form941 { get; set; }
        [DataMember]
        public string IRSPaymentType { get; set; }
        [DataMember]
        public IRSPayments IRSPayment { get; set; }
        [DataMember]
        public DepositScheduleType DepositScheduleType { get; set; }
    }
}
