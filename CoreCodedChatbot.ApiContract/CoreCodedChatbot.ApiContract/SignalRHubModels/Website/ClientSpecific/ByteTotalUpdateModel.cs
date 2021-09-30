using System.Collections;
using System.Collections.Generic;

namespace CoreCodedChatbot.ApiContract.SignalRHubModels.Website.ClientSpecific
{
    public class ByteTotalUpdateModel : AuthorizedHubRequest
    {
        public IEnumerable<string> ClientIds { get; set; }
        public string TotalBytes { get; set; }
    }
}