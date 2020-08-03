using System;

namespace CoreCodedChatbot.ApiContract.ResponseModels.Quotes.ChildModels
{
    public class Quote
    {
        public int QuoteId { get; set; }
        public string QuoteText { get; set; }
        public string CreatedBy { get; set; }
        public bool Disabled { get; set; }
        public string LastEditedBy { get; set; }
        public DateTime EditedAt { get; set; }
    }
}