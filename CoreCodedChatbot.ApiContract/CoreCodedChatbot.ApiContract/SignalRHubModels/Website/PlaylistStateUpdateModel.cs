namespace CoreCodedChatbot.ApiContract.SignalRHubModels.Website
{
    public class PlaylistStateUpdateModel : AuthorizedHubRequest
    {
        public string playlistState { get; set; }
    }
}