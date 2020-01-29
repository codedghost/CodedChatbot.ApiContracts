namespace CoreCodedChatbot.ApiContract.RequestModels.Quotes
{
    public class RemoveQuoteRequest
    {
        public string Username { get; set; }
        public int QuoteId { get; set; }
    }
}