namespace CoreCodedChatbot.ApiContract.RequestModels.Counters
{
    public class CreateCounterRequest
    {
        public string CounterName { get; set; }
        public string? CounterPreText { get; set; }
        public int? CounterInitialVal { get; set; }
    }
}