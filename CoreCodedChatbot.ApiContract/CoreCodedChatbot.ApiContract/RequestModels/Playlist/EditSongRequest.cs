namespace CoreCodedChatbot.ApiContract.RequestModels.Playlist
{
    public class EditSongRequest
    {
        public string Username { get; set; }
        public string CommandText { get; set; }
        public bool IsMod { get; set; }
    }
}