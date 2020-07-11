using System;

namespace CoreCodedChatbot.ApiContract.RequestModels.ChannelRewards
{
    public class StoreRewardRedemptionRequest
    {
        public Guid ChannelRewardId { get; set; }
        public string RedeemedBy { get; set; }
        public DateTime RedeemedAt { get; set; }
    }
}