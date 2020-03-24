namespace CoreCodedChatbot.ApiContract.ResponseModels.Playlist.ChildModels
{
    public class UnsavedSongRequest
    {
        public int SongRequestId { get; set; }
        public string ArtistName { get; set; }
        public string SongName { get; set; }
        public string UnformattedString { get; set; }
    }
}