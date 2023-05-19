using System;

namespace CoreCodedChatbot.ApiContract.ResponseModels.Counters.ChildModels
{
    public class Counter
    {
        public Guid CounterId { get; set; }
        public string CounterName { get; set; } = default!;
        public string CounterPreText { get; set; } = default!;
        public int CounterValue { get; set; }
    }
}