using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicStore.Models
{
    public class Song
    {
        public int Id { get; set; }
        public String title { get; set; }
        public String artist { get; set; }
        public DateTime releaseDate { get; set; }
        public DateTime upLoadDate { get; set; }
        public String language { get; set; }
        public int likes { get; set; }

        public TimeSpan length { get; set; }

        public String bitRate { get; set; }
        public String album { get; set; }

        public int trackNumber { get; set; }
        public String genre { get; set; }
        public Decimal price { get; set; }







    }
}