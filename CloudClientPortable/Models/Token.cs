﻿namespace CloudAPI.Rest.Client.Models {
    public class token {
        public string access_token { get; set; }
        public int expires_in { get; set; }
        public string token_type { get; set; }
    }
}
