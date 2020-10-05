namespace CoreCodedChatbot.ApiContract.RequestModels.Vip
{
    public class GiftVipRequest
    {
        public string DonorUsername { get; set; }
        public string ReceiverUsername { get; set; }
        public int NumberOfVips { get; set; }
    }
}