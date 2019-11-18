using CoreCodedChatbot.ApiContract.ResponseModels.Playlist.ChildModels;

namespace CoreCodedChatbot.ApiContract.SignalRHubModels
{
    public class SongListHubModel
    {
        public string psk { get; set; }
        public PlaylistItem currentSong { get; set; }
        public PlaylistItem[] regularRequests { get; set; }
        public PlaylistItem[] vipRequests { get; set; }
    }
}