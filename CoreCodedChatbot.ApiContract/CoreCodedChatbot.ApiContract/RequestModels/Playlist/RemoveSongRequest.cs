namespace CoreCodedChatbot.ApiContract.RequestModels.Playlist
{
    public class RemoveSongRequest
    {
        public string Username { get; set; }
        public string CommandText { get; set; }
        public bool IsMod { get; set; }
    }
}