﻿using CoreCodedChatbot.ApiContract.ResponseModels.Playlist.ChildModels;

namespace CoreCodedChatbot.ApiContract.ResponseModels.Playlist
{
    public class PlaylistModel
    {
        public PlaylistItem CurrentSong { get; set; }
        public PlaylistItem[] VipList { get; set; }
        public PlaylistItem[] RegularList { get; set; }
    }
}