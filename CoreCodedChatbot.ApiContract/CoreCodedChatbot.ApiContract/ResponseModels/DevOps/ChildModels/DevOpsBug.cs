using System.Collections.Generic;
using System.Linq;

namespace CoreCodedChatbot.ApiContract.ResponseModels.DevOps.ChildModels
{
    public class DevOpsBug : DevOpsWorkItem
    {
        public string ReproSteps { get; set; }
        public string SystemInfo { get; set; }
    }
}