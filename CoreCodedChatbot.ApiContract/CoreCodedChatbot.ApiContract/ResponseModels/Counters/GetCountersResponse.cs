using System;
using System.Collections.Generic;
using CoreCodedChatbot.ApiContract.ResponseModels.Counters.ChildModels;

namespace CoreCodedChatbot.ApiContract.ResponseModels.Counters
{
    public class GetCountersResponse : PageableResponse
    {
        public List<Counter> Counters { get; set; }
    }

}