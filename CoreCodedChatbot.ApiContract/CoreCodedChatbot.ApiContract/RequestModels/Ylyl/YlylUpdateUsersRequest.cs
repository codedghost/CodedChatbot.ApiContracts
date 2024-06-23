using System.Collections.Generic;

namespace CoreCodedChatbot.ApiContract.RequestModels.Ylyl;

public class YlylUpdateUsersRequest
{
    private List<KeyValuePair<ulong, ulong>> ChannelsToUpdate { get; set; }
}