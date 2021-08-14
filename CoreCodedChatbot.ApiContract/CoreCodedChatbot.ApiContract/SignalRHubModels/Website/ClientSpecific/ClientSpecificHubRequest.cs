namespace CoreCodedChatbot.ApiContract.SignalRHubModels.Website.ClientSpecific
{
    public abstract class ClientSpecificHubRequest : AuthorizedHubRequest
    {
        public string ClientId { get; set; }
    }
}