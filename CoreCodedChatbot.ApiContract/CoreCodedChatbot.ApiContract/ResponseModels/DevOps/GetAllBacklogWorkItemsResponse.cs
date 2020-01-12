using System.Collections.Generic;
using CoreCodedChatbot.ApiContract.ResponseModels.DevOps.ChildModels;

namespace CoreCodedChatbot.ApiContract.ResponseModels.DevOps
{
    public class GetAllBacklogWorkItemsResponse
    {
        public List<DevOpsProductBacklogItem> ProductBacklogItems { get; set; }
        public List<DevOpsBug> Bugs { get; set; }
    }
}