using System;

namespace CoreCodedChatbot.ApiContract.RequestModels.ChannelRewards
{
    public class CreateOrUpdateChannelRewardRequest
    {
        public Guid ChannelRewardId { get; set; }
        public string RewardTitle { get; set; }
        public string RewardDescription { get; set; }
    }
}