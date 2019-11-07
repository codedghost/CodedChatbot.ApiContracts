namespace CoreCodedChatbot.ApiContract.RequestModels.GuessingGame
{
    public class SubmitGuessRequest
    {
        public string Username { get; set; }
        public decimal Guess { get; set; }
    }
}