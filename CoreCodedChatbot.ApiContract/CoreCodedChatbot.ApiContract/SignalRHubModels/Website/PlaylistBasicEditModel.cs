using Newtonsoft.Json;

namespace CoreCodedChatbot.ApiContract.SignalRHubModels
{
    public class PlaylistBasicEditModel
    {
        /// <summary>
        /// Pre Shared Key to auth with SignalR hub
        /// </summary>
        public string PreSharedKey { get; set; }

        /// <summary>
        /// SongId to refer to item on the page
        /// </summary>
        [JsonProperty("songId")]
        public int SongId { get; set; }
    }
}