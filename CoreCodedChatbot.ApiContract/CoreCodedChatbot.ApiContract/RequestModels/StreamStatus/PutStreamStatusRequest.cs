namespace CoreCodedChatbot.ApiContract.RequestModels.StreamStatus
{
    public class PutStreamStatusRequest
    {
        public string BroadcasterUsername { get; set; }
        public bool IsOnline { get; set; }
    }
}