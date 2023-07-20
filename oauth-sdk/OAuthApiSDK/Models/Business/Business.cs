namespace OAuthApiSDK.Models.Business
{
    public class Business
    {
        /// <summary>
        /// Gets or sets the business identifier.
        /// </summary>
        /// <value>
        /// Unique business identifier.
        /// </value>
        public Guid? BusinessId { get; set; }
        /// <summary>
        /// Gets or sets the name of the business.
        /// </summary>
        /// <value>
        /// The business name
        /// </value>
        public string BusinessNm { get; set; }
        /// <summary>
        /// Gets or sets the trade name (DBA) of the business.
        /// </summary>
        /// <value>
        /// The trade name (DBA) of the business.
        /// </value>
        
        public string Email { get; set; }

        
    }
   

   

}
