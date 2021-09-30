using System.Collections;
using System.Collections.Generic;

namespace CoreCodedChatbot.ApiContract.SignalRHubModels.Website.ClientSpecific
{
    public class ByteTotalUpdateModel : AuthorizedHubRequest
    {
        public IEnumerable<ByteTotalUserModel> UserUpdates { get; set; }
    }

    public class ByteTotalUserModel
    {
        public string TotalBytes { get; set; }
        public string ClientId { get; set; }
    }
}