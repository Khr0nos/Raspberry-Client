namespace CloudAPI.Rest.Client.Models {
    /// <summary>
    /// Model class for Acces token definition
    /// </summary>
    public class token {
        /// <summary>
        /// Access token
        /// </summary>
        public string access_token { get; set; }
        /// <summary>
        /// Expiration time of token
        /// </summary>
        public int expires_in { get; set; }
        /// <summary>
        /// Token type
        /// </summary>
        public string token_type { get; set; }
    }
}
