namespace CoreCodedChatbot.ApiContract.RequestModels.Quotes
{
    public class SendQuoteToChatRequest
    {
        public string Username { get; set; }
        public int QuoteId { get; set; }
    }
}