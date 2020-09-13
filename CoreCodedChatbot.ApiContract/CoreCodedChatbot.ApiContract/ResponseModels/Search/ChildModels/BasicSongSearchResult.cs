using System.Collections.Generic;

namespace CoreCodedChatbot.ApiContract.ResponseModels.Search.ChildModels
{
    public class BasicSongSearchResult
    {
        public int SongId { get; set; }
        public string SongName { get; set; }
        public string ArtistName { get; set; }
        public string CharterUsername { get; set; }
        public List<string> Instruments { get; set; }
        public bool IsDownloaded { get; set; }
        public bool IsOfficial { get; set; }
        public bool IsLinkDead { get; set; }
    }
}