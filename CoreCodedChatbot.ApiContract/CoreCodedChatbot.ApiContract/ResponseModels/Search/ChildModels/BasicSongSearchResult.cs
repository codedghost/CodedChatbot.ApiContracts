﻿namespace CoreCodedChatbot.ApiContract.ResponseModels.Search.ChildModels
{
    public class BasicSongSearchResult
    {
        public int SongId { get; set; }
        public string SongName { get; set; }
        public string ArtistName { get; set; }
        public string DownloadUrl { get; set; }
    }
}