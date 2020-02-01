namespace CoreCodedChatbot.ApiContract.ResponseModels.DevOps.ChildModels
{
    public class DevOpsTask : DevOpsWorkItem
    {
        public string Description { get; set; }
        public new int RemainingWork { get; set; }
    }
}