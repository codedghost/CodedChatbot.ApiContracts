namespace CoreCodedChatbot.ApiContract.RequestModels.Playlist
{
    public class AddSongRequest
    {
        public string Username { get; set; }
        public bool IsVipRequest { get; set; }
        public string CommandText { get; set; }
    }
}