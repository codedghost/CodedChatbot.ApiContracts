namespace CoreCodedChatbot.ApiContract.ResponseModels.Quotes.ChildModels
{
    public class Quote
    {
        public int QuoteId { get; set; }
        public string QuoteText { get; set; }
        public string CreatedBy { get; set; }
        public bool Disabled { get; set; }
        public string DisabledBy { get; set; }
    }
}