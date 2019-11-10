namespace CoreCodedChatbot.ApiContract.RequestModels.Vip
{
    public class ModGiveVipRequest
    {
        public string ReceivingUsername { get; set; }
        public int VipsToGive { get; set; }
    }
}