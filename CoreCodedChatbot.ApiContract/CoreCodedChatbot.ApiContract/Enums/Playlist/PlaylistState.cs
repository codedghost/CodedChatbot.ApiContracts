namespace CoreCodedChatbot.ApiContract.Enums.Playlist
{
    public enum PlaylistState
    {
        VeryClosed,
        Closed,
        Open
    }

    public static class PlaylistStateExtensions
    {
        public static string DisplayString(this PlaylistState state)
        {
            return state switch
            {
                PlaylistState.Open => "Open",
                PlaylistState.Closed => "Vip Only",
                _ => "Closed"
            };
        }
    }
}