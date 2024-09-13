using Amazon.S3.Model;
using Form941SDK.Models.Base;
using System.Runtime.Serialization;

namespace Form941SDK.Models.Form941List
{
    [DataContract]
    public class Form941RecordsResponse:BaseResponseStatus
    {
        /// <summary>
        /// A detailed information about the Business, Employees and Form 941 records.
        /// </summary>
        [DataMember(Order = 1)]
        public List<Form941ListResponse> Form941Records { get; set; }

        /// <summary>
        /// Total number of Businesses
        /// </summary>
        [DataMember(Order = 2)]
        public int TotalRecords { get; set; }
        /// <summary>
        /// Total number of pages
        /// </summary>
        [DataMember(Order = 3)]
        public int TotalPages { get; set; }
        /// <summary>
        /// Page number
        /// </summary>
        [DataMember(Order = 4)]
        public int Page { get; set; }

        /// <summary>
        /// Range: 10, 25, 50, 100
        /// </summary>
        [DataMember(Order = 5)]
        public int PageSize { get; set; }
        /// <summary>
        /// It will show the detailed information about the error.
        /// </summary>
        [DataMember(Order = 6)]
        public List<ErrorV3> Errors { get; set; }
    }
}
