using CoreCodedChatbot.ApiContract.ResponseModels.DevOps.ChildModels;

namespace CoreCodedChatbot.ApiContract.RequestModels.DevOps
{
    public class RaiseBugRequest
    {
        public string TwitchUsername { get; set; }
        public DevOpsBug BugInfo { get; set; }
    }
}