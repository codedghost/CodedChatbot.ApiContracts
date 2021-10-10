namespace CoreCodedChatbot.ApiContract.RequestModels.Playlist
{
    public class PromoteSongRequest
    {
        public int SongRequestId { get; set; }
        public string Username { get; set; }
        public bool UseSuperVip { get; set; }
    }
}