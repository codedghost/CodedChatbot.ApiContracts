using System.Collections.Generic;

namespace CoreCodedChatbot.ApiContract.RequestModels.Ylyl;

public class YlylUpdateUsersRequest
{
    private KeyValuePair<ulong, ulong> ChannelsToUpdate { get; set; }
}