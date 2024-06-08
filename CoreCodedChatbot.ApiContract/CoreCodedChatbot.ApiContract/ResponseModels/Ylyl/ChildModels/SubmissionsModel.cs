using System;

namespace CoreCodedChatbot.ApiContract.ResponseModels.Ylyl.ChildModels;

public class SubmissionsModel
{
    public int TotalImages { get; set; }
    public int TotalVideos { get; set; }
    public TimeSpan TotalEstimatedSessionTime { get; set; }
}