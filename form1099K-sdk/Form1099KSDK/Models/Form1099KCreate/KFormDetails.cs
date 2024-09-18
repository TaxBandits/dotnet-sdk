using System.Runtime.Serialization;

namespace Form1099KSDK.Models.Form1099KCreate
{
    [DataContract]
    public class KFormDetails
    {
        [DataMember]
        public decimal B1aGrossAmt { get; set; }
        [DataMember]
        public decimal B1bCardNotPresentTxns { get; set; }
        [DataMember]
        public string B2MerchantCd { get; set; }
        [DataMember]
        public long B3NumPymtTxns { get; set; }
        [DataMember]
        public decimal B4FedTaxWH { get; set; }
        [DataMember]
        public decimal B5aJan { get; set; }
        [DataMember]
        public decimal B5bFeb { get; set; }
        [DataMember]
        public decimal B5cMar { get; set; }
        [DataMember]
        public decimal B5dApr { get; set; }
        [DataMember]
        public decimal B5eMay { get; set; }
        [DataMember]
        public decimal B5fJun { get; set; }
        [DataMember]
        public decimal B5gJul { get; set; }
        [DataMember]
        public decimal B5hAug { get; set; }
        [DataMember]
        public decimal B5iSep { get; set; }
        [DataMember]
        public decimal B5jOct { get; set; }
        [DataMember]
        public decimal B5kNov { get; set; }
        [DataMember]
        public decimal B5lDec { get; set; }
        [DataMember]
        public string AccountNum { get; set; }
        [DataMember]
        public bool Is2ndTINnot { get; set; }
        [DataMember]
        public string FilerIndicator { get; set; }
        [DataMember]
        public PSEDetails PSEDetails { get; set; }
        [DataMember]
        public string IndicateTxnsReported { get; set; }

        [DataMember]
        public List<Form1099KStateDetail> States { get; set; }

    }
    [DataContract]
    public class PSEDetails
    {
        [DataMember]
        public string PSEName { get; set; }
        [DataMember]
        public string PSEPhone { get; set; }
    }
    [DataContract]
    public class Form1099KStateDetail
    {
        [DataMember]
        public string StateCd { get; set; }
        [DataMember]
        public string StateIdNum { get; set; }
        [DataMember]
        public decimal StateWH { get; set; }
    }
}
