namespace CoreCodedChatbot.ApiContract.RequestModels.Quotes
{
    public class EditQuoteRequest
    {
        public string Username { get; set; }
        public int QuoteId { get; set; }
        public string QuoteText { get; set; }
        public bool IsMod { get; set; }
    }
}