using Newtonsoft.Json;

namespace CoreCodedChatbot.ApiContract.SignalRHubModels
{
    public class PlaylistHtmlEditModel : PlaylistBasicEditModel
    {
        /// <summary>
        /// Html to be drawn onto the page
        /// </summary>
        [JsonProperty("html")]
        public string Html { get; set; }
    }
}