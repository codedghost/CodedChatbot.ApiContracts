namespace CoreCodedChatbot.ApiContract.ResponseModels.Playlist
{
    public class GetCurrentSongRequestResponse
    {
        public string SongName { get; set; }
        public string SongArtist { get; set; }
        public string InstrumentName { get; set; }
        public string RequesterUsername { get; set; }
    }
}