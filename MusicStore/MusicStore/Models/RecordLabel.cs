using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicStore.Models
{
    public class RecordLabel
    {
        public int Id { get; set; }
        public String name { get; set; }
        public Artist artists { get; set; } 
        public Song songs { get; set; } //array of songs
        public Playlist playlists { get; set;  }
        public Album albums { get; set; }
    }
}