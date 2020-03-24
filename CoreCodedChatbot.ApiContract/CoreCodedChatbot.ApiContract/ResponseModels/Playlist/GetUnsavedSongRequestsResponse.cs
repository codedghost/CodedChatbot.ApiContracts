using System.Collections.Generic;
using CoreCodedChatbot.ApiContract.ResponseModels.Playlist.ChildModels;

namespace CoreCodedChatbot.ApiContract.ResponseModels.Playlist
{
    public class GetUnsavedSongRequestsResponse
    {
        public List<UnsavedSongRequest> UnsavedSongRequests { get; set; }
    }
}