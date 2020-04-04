using CoreCodedChatbot.ApiContract.Enums.Playlist;

namespace CoreCodedChatbot.ApiContract.ResponseModels.Playlist
{
    public class PromoteSongResponse
    {
        public int PlaylistIndex { get; set; }
        public PromoteRequestResult PromoteRequestResult { get; set; }
    }
}