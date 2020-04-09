using System.Collections.Generic;
using CoreCodedChatbot.ApiContract.ResponseModels.Playlist.ChildModels;

namespace CoreCodedChatbot.ApiContract.ResponseModels.Playlist
{
    public class GetTopTenSongsResponse
    {
        public List<PlaylistItem> TopTenSongs { get; set; }
    }
}