using System.Collections.Generic;
using CoreCodedChatbot.ApiContract.ResponseModels.DevOps.ChildModels;

namespace CoreCodedChatbot.ApiContract.ResponseModels.DevOps
{
    public class GetAllCurrentWorkItemsResponse
    {
        public List<ProductBacklogItem> ProductBacklogItems { get; set; }
    }
}