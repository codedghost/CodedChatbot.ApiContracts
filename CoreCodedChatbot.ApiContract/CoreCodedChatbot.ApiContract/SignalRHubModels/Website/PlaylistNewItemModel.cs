using CoreCodedChatbot.ApiContract.Enums.Playlist;
using Newtonsoft.Json;

namespace CoreCodedChatbot.ApiContract.SignalRHubModels
{
    public class PlaylistNewItemModel : PlaylistHtmlEditModel
    {
        /// <summary>
        /// Type of request that is being added to the page
        /// </summary>
        [JsonProperty("requestType")]
        public RequestType RequestType { get; set; }
    }
}