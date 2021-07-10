using CoreCodedChatbot.ApiContract.ResponseModels.Playlist.ChildModels;

namespace CoreCodedChatbot.ApiContract.SignalRHubModels.Website
{
    public class SongListHubModel : AuthorizedHubRequest
    {
        public PlaylistItem currentSong { get; set; }
        public PlaylistItem[] regularRequests { get; set; }
        public PlaylistItem[] vipRequests { get; set; }
    }
}