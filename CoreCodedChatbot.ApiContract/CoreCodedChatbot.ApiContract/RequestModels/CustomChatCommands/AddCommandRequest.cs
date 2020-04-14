using System.Collections.Generic;

namespace CoreCodedChatbot.ApiContract.RequestModels.CustomChatCommands
{
    public class AddCommandRequest
    {
        public List<string> Aliases { get; set; }
        public string InformationText { get; set; }
        public string HelpText { get; set; }
        public string Username { get; set; }
    }
}