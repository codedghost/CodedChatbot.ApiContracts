using CoreCodedChatbot.ApiContract.Enums.Playlist;

namespace CoreCodedChatbot.ApiContract.ResponseModels.Playlist
{
    public class AddRequestResponse
    {
        public AddRequestResult Result { get; set; }
        public int PlaylistPosition { get; set; }
        public string FormattedSongText { get; set; }
    }
}