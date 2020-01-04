using System.Collections.Generic;
using System.Linq;

namespace CoreCodedChatbot.ApiContract.ResponseModels.DevOps.ChildModels
{
    public abstract class ParentWorkItem
    {
        public string Title { get; set; }
        public string State { get; set; }
        public string AssignedTo { get; set; }
        public string AcceptanceCriteria { get; set; }
        public List<Task> Tasks { get; set; }

        public int RemainingWork => Tasks.Sum(task => task.RemainingWork);
    }
}