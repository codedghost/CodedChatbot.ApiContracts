namespace CoreCodedChatbot.ApiContract.RequestModels.ClientTrigger
{
    public class SendBackgroundSongResultRequest
    {
        public string Username { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Url { get; set; }
    }
}