namespace CoreCodedChatbot.ApiContract.RequestModels.Ylyl;

public class YlylSubmissionRequest
{
    public ulong ChannelId { get; set; }
    public ulong MessageId { get; set; }
    public ulong UserId { get; set; }
    public int TotalImages { get; set; }
    public int TotalVideos { get; set; }
}