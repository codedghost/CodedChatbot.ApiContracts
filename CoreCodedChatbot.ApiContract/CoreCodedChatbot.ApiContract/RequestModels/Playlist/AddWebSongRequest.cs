namespace CoreCodedChatbot.ApiContract.RequestModels.Playlist
{
    public class AddWebSongRequest
    {
        public int SongRequestId { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public string SelectedInstrument { get; set; }
        public bool IsVip { get; set; }
        public bool IsSuperVip { get; set; }
        public string Username { get; set; }
    }
}