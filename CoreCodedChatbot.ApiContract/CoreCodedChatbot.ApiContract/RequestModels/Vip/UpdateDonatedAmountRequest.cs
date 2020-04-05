namespace CoreCodedChatbot.ApiContract.RequestModels.Vip
{
    public class UpdateDonatedAmountRequest
    {
        public string Username { get; set; }
        public int AmountDonated { get; set; }
    }
}