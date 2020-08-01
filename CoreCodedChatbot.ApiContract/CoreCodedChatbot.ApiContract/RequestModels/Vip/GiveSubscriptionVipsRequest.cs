using System.Collections.Generic;
using CoreCodedChatbot.ApiContract.RequestModels.Vip.ChildModels;

namespace CoreCodedChatbot.ApiContract.RequestModels.Vip
{
    public class GiveSubscriptionVipsRequest
    {
        public List<UserSubDetail> UserSubDetails { get; set; }
    }
}