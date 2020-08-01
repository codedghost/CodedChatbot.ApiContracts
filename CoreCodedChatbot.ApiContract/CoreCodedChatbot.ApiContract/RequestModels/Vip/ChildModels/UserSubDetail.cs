using CoreCodedChatbot.ApiContract.Enums.VIP;

namespace CoreCodedChatbot.ApiContract.RequestModels.Vip.ChildModels
{
    public class UserSubDetail
    {
        public string Username { get; set; }
        public int TotalSubMonths { get; set; }
        public int SubStreak { get; set; }
        public SubscriptionTier SubscriptionTier { get; set; }
    }
}