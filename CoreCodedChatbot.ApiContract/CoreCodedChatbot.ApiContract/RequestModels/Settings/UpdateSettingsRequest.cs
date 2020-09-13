using System;
using System.Collections.Generic;
using System.Text;

namespace CoreCodedChatbot.ApiContract.RequestModels.Settings
{
    public class UpdateSettingsRequest
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
