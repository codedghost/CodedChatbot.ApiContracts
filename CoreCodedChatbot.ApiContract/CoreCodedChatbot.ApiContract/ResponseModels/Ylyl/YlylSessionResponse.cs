using CoreCodedChatbot.ApiContract.Enums.Ylyl;
using CoreCodedChatbot.ApiContract.ResponseModels.Ylyl.ChildModels;

namespace CoreCodedChatbot.ApiContract.ResponseModels.Ylyl;

public class YlylSessionResponse
{
    public YlylSessionOperation YlylSessionOperation { get; set; }
    public SubmissionsModel SubmissionsModel { get; set; }
    public bool IsOperationSuccessful { get; set; }
}