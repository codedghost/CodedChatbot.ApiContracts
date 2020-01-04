namespace CoreCodedChatbot.ApiContract.ResponseModels.DevOps.ChildModels
{
    public class Task
    {
        public string Title { get; set; }
        public string State { get; set; }
        public string Description { get; set; }
        public string AssignedTo { get; set; }
        public int RemainingWork { get; set; }
    }
}