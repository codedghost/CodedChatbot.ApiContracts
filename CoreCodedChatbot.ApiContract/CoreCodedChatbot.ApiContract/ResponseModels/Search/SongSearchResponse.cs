using System.Collections.Generic;
using CoreCodedChatbot.ApiContract.ResponseModels.Search.ChildModels;

namespace CoreCodedChatbot.ApiContract.ResponseModels.Search
{
    public class SongSearchResponse
    {
        public List<BasicSongSearchResult> SearchResults { get; set; }
    }
}