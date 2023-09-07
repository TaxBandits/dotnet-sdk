using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Form1099NecSDK.Models.Form1099NEC
{
    [DataContract]
    public class NecFormDetails
    {
        [DataMember]
        //[Range(0, 9999999999.99, ErrorMessage = "ERR-BOX1-01:Maximum 12 characters only allowed")]
        public decimal B1NEC { get; set; }

        [DataMember]
        public bool B2IsDirectSales { get; set; }

        [DataMember]
        //[Range(0, 9999999999.99, ErrorMessage = "ERR-BOX4-01:Maximum 12 characters only allowed")]
        public decimal B4FedTaxWH { get; set; }
       
        /// </summary>
        [DataMember]
        //[MaxLength(20, ErrorMessage = "ERR-ACCNUM-01:Maximum 20 characters only allowed")]
        //[MinLength(4, ErrorMessage = "ERR-ACCNUM-02:Enter minimum 4 characters")]
       
        public string AccountNum { get; set; }

        /// <summary>
        /// Check this box if you were notified by the IRS twice within 3 calendar years that the payee provided an incorrect TIN so that the IRS doesn't send you any more notices about this account.
        /// </summary>
        [DataMember]
        public bool Is2ndTINnot { get; set; }
        [DataMember]
        public List<Form1099StateDetail> States { get; set; }
    }
    [DataContract]
    public class Form1099StateDetail
    {
        [DataMember]
        public string StateCd { get; set; }
        [DataMember]
        public decimal StateWH { get; set; }
        [DataMember]
        public string StateIdNum { get; set; }
        [DataMember]
        public decimal StateIncome { get; set; }
    }
}
