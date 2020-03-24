using System;

namespace CoreCodedChatbot.ApiContract.RequestModels.Playlist
{
    public class StoreSongInfoAndAddToDriveRequest
    {
        public int SongRequestId { get; set; }
        public int SongId { get; set; }
        public string SongTitle { get; set; }
        public string SongArtist { get; set; }
        public string AlbumName { get; set; }
        public decimal ChartVersion { get; set; }
        public string CharterUsername { get; set; }
        public DateTime UploadedDateTime { get; set; }
        public DateTime UpdatedDateTime { get; set; }
        public string DownloadUrl { get; set; }
    }
}