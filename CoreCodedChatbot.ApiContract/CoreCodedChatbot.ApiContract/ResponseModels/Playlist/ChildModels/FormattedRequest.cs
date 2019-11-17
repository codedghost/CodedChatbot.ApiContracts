using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CoreCodedChatbot.ApiContract.ResponseModels.Playlist.ChildModels
{
    public class FormattedRequest
    {
        private static Regex SongRequestRegex = new Regex(
            "((?<artistname>[\\d\\w ,.!\"£$%^&*=+\\\\\\/|<>?`¬[\\]{};\'#:@~\\-]*)(?<seperator2> - )(?<songname>[\\d\\w ,.!\"£$%^&*=+\\\\\\/|<>?`¬[\\]{};\'#:@~\\-]*)(?<instrument>(( - )?\\(?(bass|guitar)?\\)?)?))");

        public string SongName { get; set; }
        public string SongArtist { get; set; }
        public string InstrumentName { get; set; }

        public static FormattedRequest GetFormattedRequest(string requestText)
        {
            Match regMatch = SongRequestRegex.Match(requestText);

            string possibleInstrument = requestText.IndexOf("bass", StringComparison.OrdinalIgnoreCase) >= 0 ? "bass" : "guitar";

            return SongRequestRegex.IsMatch(requestText)
                ? new FormattedRequest
                {
                    SongName = regMatch.Groups["songname"].Captures.Count > 0 ? regMatch.Groups["songname"].Captures[0].Value.Trim() : string.Empty,
                    SongArtist = regMatch.Groups["artistname"].Captures.Count > 0 ? regMatch.Groups["artistname"].Captures[0].Value.Trim() : string.Empty,
                    InstrumentName = possibleInstrument
                }
                : null;
        }
    }
}