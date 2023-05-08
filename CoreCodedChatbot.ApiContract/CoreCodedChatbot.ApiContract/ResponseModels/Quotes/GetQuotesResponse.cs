using System.Collections.Generic;
using CoreCodedChatbot.ApiContract.ResponseModels.Quotes.ChildModels;

namespace CoreCodedChatbot.ApiContract.ResponseModels.Quotes
{
    public class GetQuotesResponse : PageableResponse
    {
        public List<Quote> Quotes { get; set; }
    }
}