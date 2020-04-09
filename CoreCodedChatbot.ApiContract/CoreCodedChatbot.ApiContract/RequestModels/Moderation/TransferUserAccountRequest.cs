namespace CoreCodedChatbot.ApiContract.RequestModels.Moderation
{
    public class TransferUserAccountRequest
    {
        public string RequestingModerator { get; set; }
        public string OldUsername { get; set; }
        public string NewUsername { get; set; }
    }
}