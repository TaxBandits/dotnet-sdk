using System.Runtime.Serialization;

namespace Form1099MISCSDK.Models.Form1099MISCCreate
{
    [DataContract]
    public class Form1099MiscDetails
    {
        [DataMember]
        public decimal B1Rents { get; set; }
        [DataMember]
        public decimal B2Royalties { get; set; }
        [DataMember]
        public decimal B3OtherIncome { get; set; }
        [DataMember]
        public decimal B4FedIncomeTaxWH { get; set; }
        [DataMember]
        public decimal B5FishingBoatProceeds { get; set; }
        [DataMember]
        public decimal B6MedHealthcarePymts { get; set; }
        [DataMember]
        public bool B7IsDirectSale { get; set; }
        [DataMember]
        public decimal B8SubstitutePymts { get; set; }
        [DataMember]
        public decimal B9CropInsurance { get; set; }
        [DataMember]
        public decimal B10GrossProceeds { get; set; }
        [DataMember]
        public decimal B11FishPurForResale { get; set; }
        [DataMember]
        public decimal B12Sec409ADeferrals { get; set; }
        [DataMember]
        public bool B13IsFATCA { get; set; }
        [DataMember]
        public decimal B14EPP { get; set; }
        [DataMember]
        public decimal B15NonQualDefComp { get; set; }
        [DataMember]
        public string AccountNum { get; set; }
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
