using System.Runtime.Serialization;

namespace Form941SDK.Models.Form941Create
{
    [DataContract]
    public class Form8453Emp
    {
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string AttachmentNm { get; set; }

        /// <summary>
        /// Bytes of Form-8453 pdf
        /// </summary>
        [DataMember]
        public byte[] Attachment { get; set; }

        /// <summary>
        /// Attachment Type
        /// </summary>
        [DataMember]
        public string AttachmentFileType { get; set; }

        /// <summary>
        /// Date on which the Form 8453-EMP was signed
        /// </summary>
        [DataMember]
        public DateTime SignedDate { get; set; }
    }
}
