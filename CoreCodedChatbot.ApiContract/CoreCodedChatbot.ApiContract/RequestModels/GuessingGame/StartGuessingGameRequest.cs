namespace CoreCodedChatbot.ApiContract.RequestModels.GuessingGame
{
    public class StartGuessingGameRequest
    {
        public string SongName { get; set; }
        public int SongLengthSeconds { get; set; }
    }
}